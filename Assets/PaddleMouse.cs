using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sc : MonoBehaviour

{
    public float speed = 10.0f;
    public float boundY = 2.25f;
    public float boundX = 20.4f;
    private Rigidbody2D rb2d;

    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        // Obtém a posição do mouse em coordenadas de mundo
        Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        // Define a posição do paddle para a posição do mouse
        Vector3 targetPosition = new Vector3(mousePos.x, mousePos.y, transform.position.z);

        // Limita a posição do paddle para evitar que ele saia dos limites
        targetPosition.x = Mathf.Clamp(targetPosition.x, -boundX, boundX);
        targetPosition.y = Mathf.Clamp(targetPosition.y, -boundY, boundY);

        // Move o paddle suavemente em direção à posição do mouse
        transform.position = Vector3.MoveTowards(transform.position, targetPosition, speed * Time.deltaTime);
    }
}
