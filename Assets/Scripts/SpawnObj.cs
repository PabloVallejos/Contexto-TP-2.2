using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpawnObj : MonoBehaviour
{
    public GameObject trg;
    public Transform loc;
    public UI ui;
    public Text texto;
    public string nombre;
    private float timer;
    private bool can;

    private void Start()
    {
        ui = FindObjectOfType<UI>();
    }

    private void FixedUpdate()
    {
        if (timer >= 0)
        {
            timer -= Time.deltaTime;
            texto.text = "Proximo en: " + timer;
        }
        if (timer <= 0)
        {
            can = true;
            texto.text = nombre;
        }
        if (ui.times <= 0)
        {
            texto.text = "Sin arena";
        }
    }

    public void SpawnObject()
    {
        if(ui.times >= 0 && can == true)
        {
            Instantiate(trg, loc.position, Quaternion.Euler(-90, 90, 0));
            ui.times -= 1;
            timer = 3;
            can = false;
        }
    }
}
