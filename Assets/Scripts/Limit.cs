using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Limit : MonoBehaviour
{
    public Transform spawner;
    public UI ui;

    private void Start()
    {
        ui = FindObjectOfType<UI>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Enemy" || other.gameObject.tag == "Bullet")
        {
            Destroy(other.gameObject);
        }
        else { other.transform.position = spawner.position; }
    }
}
