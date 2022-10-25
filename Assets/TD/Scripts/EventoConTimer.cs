using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class EventoConTimer : MonoBehaviour
{
    public float tiempoEntreEventos;

    public UnityEvent evento;
    public bool puedeEjecutarEvento;

    float t = 0;

    void EjecutarEvento()
    {
        evento.Invoke();
    }

    private void Update()
    {
        if(puedeEjecutarEvento)
        {
            t += Time.deltaTime;
            if(t >= tiempoEntreEventos)
            {
                EjecutarEvento();
                t = 0;
            }
        }
    }

    public void SwitchEvento(bool _estado)
    {
        puedeEjecutarEvento = _estado;
    }
}
