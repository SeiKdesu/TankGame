using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Collider : MonoBehaviour
{
  
    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "tankteki")
        {
            Destroy(gameObject);
            Destroy(other.gameObject);
            SceneManager.LoadScene("finish");
        }
    }
}
