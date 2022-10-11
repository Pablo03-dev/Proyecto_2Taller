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

    // Start is called before the first frame update
    void Start()
    {
        timeToSpawn = Random.Range(MinTime, MxTime);
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (timer >= timeToSpawn && aux == null)
        {
            Spawn();
            // Destroy(objeto, 6f);
        }
    }

    void Spawn()
    {
        int indice = Random.Range(0, obstaculos.Length);
        aux = Instantiate(obstaculos[indice], transform.position, Quaternion.identity);
        timer = 0f;
        timeToSpawn = Random.Range(MinTime, MxTime);
        aux = null;
    }
}
