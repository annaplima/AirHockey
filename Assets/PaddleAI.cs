using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAI : MonoBehaviour
{
   public float speed = 0.05f;
    public float boundY = 2.25f;

    private Rigidbody2D rb2d;
    private GameObject bola; // Referência ao objeto da bola

    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        // Encontre o objeto da bola com base na tag "Ball"
        bola = GameObject.FindGameObjectWithTag("Ball");
    }

    // Update is called once per frame
    void Update()
    {
        if (bola != null) // Verifica se a referência da bola não é nula
        {
            // Calcula a direção da bola em relação à IA
            Vector2 directionToBall = bola.transform.position - transform.position;

            // Normaliza a direção para garantir que a velocidade seja constante
            directionToBall.Normalize();

            // Move a IA na direção vertical da bola
            rb2d.velocity = new Vector2(0, directionToBall.y * speed);

            // Limita a posição da IA para evitar que ela saia dos limites
            Vector3 currentPosition = transform.position;
            currentPosition.y = Mathf.Clamp(currentPosition.y, -boundY, boundY);
            transform.position = currentPosition;
        }
    }
}