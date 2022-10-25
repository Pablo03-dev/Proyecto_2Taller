using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
public class SeguirRecorrido : MonoBehaviour
{
    public Vector3[] puntosRecorrido;
    public float speed;
    public UnityEvent onComplete;
    bool completoElrecorrido;
    int indicePuntos;


    private void Start()
    {
        transform.position = puntosRecorrido[0];
    }

    private void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, puntosRecorrido[indicePuntos], speed * Time.deltaTime);

        if (transform.position == puntosRecorrido[indicePuntos])
        {
            if(indicePuntos == puntosRecorrido.Length-1)
            {
                TerminarRecorrido();
            }
            else
            {
                indicePuntos++;
            }
        }


    }

    void TerminarRecorrido()
    {
        if (completoElrecorrido) return;

        onComplete.Invoke();
        completoElrecorrido = true;
    }
}
