using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoalSound : MonoBehaviour
{
   private AudioSource audioSource;

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    public void PlayGoalSound()
    {
        if (audioSource != null)
        {
            audioSource.Play();
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
