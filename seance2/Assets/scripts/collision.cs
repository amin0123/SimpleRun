using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collision : MonoBehaviour
{
    // Start is called before the first frame update
   
    void Start()
    {
        
    }

    // Update is called once per frame

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag.Equals("coin"))
        {
            Destroy(other.gameObject);
        }
       /* if(other.gameObject.tag.Equals("water"))
        {

        }*/
    }
}
