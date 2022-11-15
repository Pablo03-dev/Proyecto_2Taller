using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Destroyer : MonoBehaviour
{

    public float time = 0;
    public float cooldown = 7;
    public Image protector;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
    }

    public void DestroyAllObjects()
    {
        if (time >= cooldown)
        {
            foreach (var gameObj in GameObject.FindGameObjectsWithTag("enemigo"))
            {
                
                Destroy(gameObj);
                
            }

            protector.enabled = true;

            cooldown += time;
        }
        
        if (time <= cooldown)
        {
            protector.enabled = false;
        }
        
        
    }

}
