using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PinataScript : MonoBehaviour
{
    public PinataSpawner spawnScript;
    



    void OnCollisionEnter(Collision collision)
    {
        destroyPinata(collision);
    }

    public void destroyPinata(Collision collision)
    {
        spawnScript = GameObject.FindGameObjectWithTag("Spawner").GetComponent<PinataSpawner>();
        spawnScript.setAlive();
        }
}
