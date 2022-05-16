using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float speed;

    private void FixedUpdate()
    {
        this.gameObject.GetComponent<Rigidbody>().velocity = transform.TransformDirection(Vector3.left * speed);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Bullet")
        {
            Destroy(this.gameObject);
        }
    }
}
