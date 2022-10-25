using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
public class BuscarEnemigos : MonoBehaviour
{
    public float radioDeBusqueda;
    public LayerMask layerEnemigos;
    float t = 0;

    public UnityEvent onDetectEnemy;
    public UnityEvent onNoneEnemy;
    bool noHayEnemigos = true;
    int enemigoDetectado;
    public bool activarTorreta;

    public Transform EnemigoMasCercano()
    {
        Collider2D[] collidersEnemigos = Physics2D.OverlapCircleAll(transform.position, radioDeBusqueda, layerEnemigos);

        float distanciaMasCorta = Mathf.Infinity;

        Transform transformEnemigoMasCercano = null;

        if(collidersEnemigos.Length > 0)
        {
            for (int i = 0; i < collidersEnemigos.Length; i++)
            {
                Vector3 direccionAltarget = collidersEnemigos[i].transform.position - transform.position;
                float distanciaAlTargetAlCuadrado = direccionAltarget.sqrMagnitude;

                if (distanciaAlTargetAlCuadrado < distanciaMasCorta)
                {
                    distanciaMasCorta = distanciaAlTargetAlCuadrado;
                    transformEnemigoMasCercano = collidersEnemigos[i].transform;
                }
            }
        }

        return transformEnemigoMasCercano;

    }


    private void Update()
    {
        if (!activarTorreta)
            return;

        TratarDeDetectarEnemigos();
    }

    public void AlDetectarEnemigos()
    {
        onDetectEnemy.Invoke();
    }

    public void AlNoDetectarEnemigos()
    {
        onNoneEnemy.Invoke();
    }

    void TratarDeDetectarEnemigos()
    {

        // Primero trata de encontrar un enemigo
        Transform transforEnemigo = EnemigoMasCercano();

        // si encuentra un enemigo cambia la orientacion
        if (transforEnemigo != null)
        {
            Vector3 direccion = transforEnemigo.position - transform.position;
            transform.up = direccion;
            AlDetectarEnemigos();
        }
        else
        {
            AlNoDetectarEnemigos();

        }
    }

    public void SwitchTorreta(bool _state)
    {
        activarTorreta = _state;
    }

}
