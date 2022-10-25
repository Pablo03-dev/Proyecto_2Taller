using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawnear : MonoBehaviour
{
    public bool usarLocalTransform;
    public Transform spawnPoint;
   

    public void Spawn(GameObject _spawnObject)
    {
        Vector3 posicionSpawn = usarLocalTransform ? transform.position : spawnPoint.position;
        Quaternion rotacionSpawn = usarLocalTransform ? transform.rotation : spawnPoint.rotation;

        Instantiate(_spawnObject, posicionSpawn, rotacionSpawn);
    }

    public void SpawnEnLocal(GameObject _spawnObject)
    {
        Instantiate(_spawnObject, transform.position, transform.rotation);
    }
}
