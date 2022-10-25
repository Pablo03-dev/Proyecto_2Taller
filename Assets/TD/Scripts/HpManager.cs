using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
public class HpManager : MonoBehaviour
{
    public int hp;
    public UnityEvent onHit;
    public UnityEvent onDead;
    
    public void HacerDaño()
    {
        hp --;

        if (hp <= 0)
        {
            onDead.Invoke();
        }
        else
        {
            onHit.Invoke();
        }
    }

}
