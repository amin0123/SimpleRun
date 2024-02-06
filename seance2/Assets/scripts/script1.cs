using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class script1 : MonoBehaviour
{
    [SerializeField] private Rigidbody rb;
    public float speed;
    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }


    private void Update()
    {
        //rb.AddForce(Vector3.forward * speed * Time.deltaTime, ForceMode.Acceleration);
        rb.velocity = new Vector3(0,0,1);
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag.Equals("floor"))
        {
            Debug.Log("collided");
        }
    }

    private void OnCollisionStay(Collision collision)
    {
        if (collision.gameObject.tag.Equals("floor"))
        {
            Debug.Log("staay");
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("triggered");
    }
}
