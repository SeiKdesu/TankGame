using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletshot : MonoBehaviour
{
    public GameObject bullet;
    public float bulletSpeed;
    bool Rug = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0) && Rug == false)
        {
            GameObject Bullet = (GameObject)Instantiate(bullet, transform.position, Quaternion.Euler(transform.parent.eulerAngles.x, transform.parent.eulerAngles.y, 0));
            Rigidbody bulletRb = Bullet.GetComponent<Rigidbody>();
            bulletRb.AddForce(transform.forward * -bulletSpeed);
            Destroy(Bullet, 3.0f);

            Rug = true;
            Invoke("ROG", 0.5f);
        }
    }
    void ROG()
    {
        Rug = false;
    }
}
