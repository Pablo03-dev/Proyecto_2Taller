using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trasladar : MonoBehaviour
{
    public float speed;

    void Mover()
    {
        transform.Translate(transform.up * speed * Time.deltaTime,Space.World);
    }

    private void Update() => Mover();

}
