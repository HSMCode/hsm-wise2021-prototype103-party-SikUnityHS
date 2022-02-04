using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitPinata : MonoBehaviour
{
    public ParticleSystem deathParticles;
    private GameObject Pinata;
    public AudioSource BatHit;

  void Start () {

     BatHit = GetComponent<AudioSource> ();
  }

    private void OnCollisionEnter(Collision col)
    {
      if (col.gameObject.tag == "Pinata")
      {
        Destroy();
        BatHit.Play ();
        
  
      }
    }

   public void Destroy()
   {
    
     Instantiate(deathParticles, new Vector3 (9.5f, -11f, -11.5f),transform.rotation * Quaternion.Euler (0,180,0) );
     Pinata = GameObject.FindGameObjectWithTag ("Pinata");
     DestroyObject (Pinata);
    
   }


}
