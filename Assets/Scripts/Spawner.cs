using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject[] obstaculos;
    public GameObject objeto;
    public float timer = 0f;
    public float MinTime;
    public float MxTime;
    public float timeToSpawn = 6f;

    public GameObject aux;
    public bool empezar;

    // Start is called before the first frame update
    void Start()
    {
        timeToSpawn = Random.Range(MinTime, MxTime);
        empezar = false;
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        StartSpawn();
    }

    void Spawn()
    {
        int indice = Random.Range(0, obstaculos.Length);
        aux = Instantiate(obstaculos[indice], transform.position, Quaternion.identity);
        timer = 0f;
        timeToSpawn = Random.Range(MinTime, MxTime);
        aux = null;
    }

    public void StartSpawn()
    {
        if (timer >= timeToSpawn && aux == null && empezar == true)
        {
            Spawn();
            // Destroy(objeto, 6f);
        }
    }

    public void BotontoStart()
    {
        empezar = true;
    }
}
