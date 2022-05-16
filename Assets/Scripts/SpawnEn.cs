using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEn : MonoBehaviour
{
    public GameObject enemy;
    public float set;
    private float timer = 20;

    private void FixedUpdate()
    {
        timer -= Time.deltaTime;

        if (timer <= 0)
        {
            Instantiate(enemy, transform.position, transform.rotation);
            timer = set;
        }
    }
}
