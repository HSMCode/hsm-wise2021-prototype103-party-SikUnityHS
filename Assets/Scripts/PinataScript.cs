using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PinataScript : MonoBehaviour
{

    public PinataSpawner spawnScript;
    public ScoreScript scoreScript;
    //public SoundEffectsScript soundEffectsScript;


    void OnCollisionEnter(Collision collision)
    {
        destroyPassenger(collision);
    }

    public void destroyPassenger(Collision collision)
    {
        spawnScript = GameObject.FindGameObjectWithTag("Spawner").GetComponent<PinataSpawner>();
        spawnScript.setAlive();
        }
}
