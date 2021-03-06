using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PinataSpawner : MonoBehaviour
{
    public GameObject Pinata;
    public bool isAlive = false;
    

    void Start()
    {
        StartCoroutine(PinataWave());
    }

    private void spawnPinata()
    {

        GameObject targetClone = Instantiate(Pinata) as GameObject;
        targetClone.transform.position = new Vector3(-8, 4, -84);


        isAlive = false;
    }

    IEnumerator PinataWave()
    {
        while (true)
        {
           yield return new WaitForSeconds(4);

           if (isAlive == true)
           {
               spawnPinata();
           } 
        }
    }

    public void setAlive()
    {
      isAlive = true;

    }

}
