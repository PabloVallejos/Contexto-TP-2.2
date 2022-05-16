using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cañon : MonoBehaviour
{
    public Rigidbody bullet;
    public Transform barrel;
    private float timer = 5;

    // Update is called once per frame
    void FixedUpdate()
    {
        timer -= Time.deltaTime;
        Debug.Log("Firing in: " + timer);

        if (timer <= 0)
        {
            timer = 5;
            Rigidbody clone;
            clone = Instantiate(bullet, barrel.position, barrel.rotation);
            clone.velocity = transform.TransformDirection(Vector3.down * 50);
            this.GetComponent<Rigidbody>().velocity = transform.TransformDirection(Vector3.up * 5);
            Debug.Log("FIRE");
        }
    }
}
