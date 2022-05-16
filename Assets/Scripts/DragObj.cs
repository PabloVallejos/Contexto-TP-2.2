using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragObj : MonoBehaviour
{
    private Vector3 offset;

    private float mZ;

    private Vector3 GetMouseWorldPos()
    {
        Vector3 mouseInput = Input.mousePosition;

        mouseInput.z = mZ;

        return Camera.main.ScreenToWorldPoint(mouseInput);
    }

    void OnMouseDown()
    {
        mZ = Camera.main.WorldToScreenPoint(gameObject.transform.position).z;
        offset = gameObject.transform.position - GetMouseWorldPos();
    }

    void OnMouseDrag()
    {
        transform.position = GetMouseWorldPos() + offset;
        transform.rotation = Quaternion.Euler(-90, 90, 0);
    }
}
