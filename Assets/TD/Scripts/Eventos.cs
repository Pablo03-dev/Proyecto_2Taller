using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[System.Serializable]
public class Event
{
    public string nombre;
    public UnityEvent evento;

    public void Ejecutar()
    {
        evento.Invoke();
    }
}

public class Eventos : MonoBehaviour
{
    public Event[] arregloDeEventos;

    public void EjecutarEvento(string _nombre)
    {
        for (int i = 0; i < arregloDeEventos.Length; i++)
        {
            if(arregloDeEventos[i].nombre == _nombre)
            {
                arregloDeEventos[i].Ejecutar();
            }
        }
    }
}


