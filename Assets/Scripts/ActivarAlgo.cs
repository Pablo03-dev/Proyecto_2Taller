using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ActivarAlgo : MonoBehaviour
{
    [SerializeField] private UnityEvent Presionado;

    //private void OnTriggerEnter(Collider other)
    //{
    //    if (other.gameObject.CompareTag("Bola"))
    //    {
    //        Presionado?.Invoke();
    //    }
    //}

    private void OnTriggerEnter2D(Collider2D collision)
    {
        //if (collision.gameObject.CompareTag("Bola"))
        //{
        //    Presionado?.Invoke();
        //    Audiomanager.PlaySound("BolaInicia");
        //}
    }
}
