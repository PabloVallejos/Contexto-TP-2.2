using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI : MonoBehaviour
{
    public Button[] boton;
    public Button next;
    public Text texto;
    public Text goal;
    public int times;
    public float time;

    private void Start()
    {
        next.enabled = false;
    }

    private void FixedUpdate()
    {
        if (times <= 0)
        {
            boton[boton.Length - 1].enabled = false;
        }
        if (time <= 0)
        {
            texto.text = "GANASTE";
            goal.text = "";
            next.enabled = true;
            goal.text = "Done";
        }
        goal.text = "Para ganar: " + time;
    }
}
