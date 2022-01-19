using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitPinata : MonoBehaviour
{

    private void OnCollisionEnter(Collision col)
    {
      if (col.gameObject.tag == "Pinata")
      {
        
        Destroy(col.gameObject);

      }



    }


}
