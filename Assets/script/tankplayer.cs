using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tankplayer : MonoBehaviour
{
    float inputHorizontal;
    float inputVertical;
    Rigidbody rb;
    float speed = 3.0f;
    AudioSource audioSource;

   
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        audioSource = GetComponent<AudioSource>();
    }

    void Update()
    {
        // Wキー（前方移動）
        if (Input.GetKey(KeyCode.W))
        {
            transform.position += speed * transform.forward * Time.deltaTime;
            //audioSource.PlayOneShot(audioSource.clip);
        }

        // Sキー（後方移動）
        if (Input.GetKey(KeyCode.S))
        {
            transform.position -= speed * transform.forward * Time.deltaTime;
            //audioSource.PlayOneShot(audioSource.clip);
        }

        // Dキー（右移動）
        if (Input.GetKey(KeyCode.D))
        {
            transform.position += speed * transform.right * Time.deltaTime;
            //audioSource.PlayOneShot(audioSource.clip);
        }

        // Aキー（左移動）
        if (Input.GetKey(KeyCode.A))
        {
            transform.position -= speed * transform.right * Time.deltaTime;
            //audioSource.PlayOneShot(audioSource.clip);
        }
      


    }

    
}