using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[System.Serializable]
public class Evento 
{
    public string tag;
    public bool destruirAlOther;
    public UnityEvent eventos;

    public void ChequearEvento(Collider2D _otherCollider)
    {
        if (_otherCollider.tag == tag)
        {
            eventos.Invoke();
        }
    }

    public bool PuedeDestruir() => destruirAlOther;


}

public class DetectarColision : MonoBehaviour
{

    public List<Evento> onEnter = new List<Evento>();
    public List<Evento> onStay = new List<Evento>();
    public List<Evento> onExit = new List<Evento>();


    private void OnTriggerEnter2D(Collider2D collision)
    {
        RecorrerLista(onEnter, collision);

    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        RecorrerLista(onStay, collision);
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        RecorrerLista(onExit, collision);
    }

    void RecorrerLista(List<Evento> _evento, Collider2D _collider2D)
    {
        for(int i = 0; i < _evento.Count; i++)
        {
            _evento[i].ChequearEvento(_collider2D);
            if(_evento[i].PuedeDestruir())
            {
                Destroy(_collider2D.gameObject);
            }
        }
    }
}
