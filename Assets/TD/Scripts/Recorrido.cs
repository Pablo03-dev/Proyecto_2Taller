using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.U2D;
public class Recorrido : MonoBehaviour
{
    public Vector3[] puntosRecorrido;
    public SpriteShapeController spriteShape;

    private void Awake()
    {
        int length = spriteShape.spline.GetPointCount();
        puntosRecorrido = new Vector3[length];


        for (int i = 0; i < length; i++)
        {
            puntosRecorrido[i] = spriteShape.spline.GetPosition(i);
        }
    }

}
