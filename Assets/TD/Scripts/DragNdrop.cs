using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class DragNdrop : MonoBehaviour
{

    bool isDragging;
    Vector3 diferencia;
    public UnityEvent onMouseDown;
    public UnityEvent onMouseUp;
    bool desactivarDrag;

    private void OnMouseDown()
    {
        if (desactivarDrag) return;
        isDragging = true;
        Vector3 mousePos = Input.mousePosition;
        mousePos.z = Mathf.Abs(Camera.main.transform.position.z);
        Vector3 worldPos = Camera.main.ScreenToWorldPoint(mousePos);
        diferencia = transform.position - worldPos;
        onMouseDown.Invoke();
    }

    private void OnMouseDrag()
    {
        if (desactivarDrag) return;
        Vector3 mousePos = Input.mousePosition;
        mousePos.z = Mathf.Abs(Camera.main.transform.position.z);
        Vector3 worldPos = Camera.main.ScreenToWorldPoint(mousePos);
        transform.position = worldPos + diferencia;
    }

    private void OnMouseUpAsButton()
    {
        if (desactivarDrag) return;
        isDragging = false;
        onMouseUp.Invoke();
    }


    public void SwitchComponente(bool _state)
    {
        desactivarDrag = _state;
    }
}
