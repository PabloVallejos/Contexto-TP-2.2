using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Target : MonoBehaviour
{
    public Text goal;
    public UI ui;
    public DragObj[] play;
    private bool done;

    private void FixedUpdate()
    {
        if (done == true)
        {
            ui.time = ui.time - Time.deltaTime;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
         goal.text = "Altura correcta, mantenlo estable.";
         done = true;
    }

    private void OnTriggerExit(Collider other)
    {
        goal.text = "Se cayo :(";
        done = false;
        ui.time = 5;
    }
}
