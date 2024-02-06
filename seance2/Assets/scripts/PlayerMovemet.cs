using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovemet : MonoBehaviour
{
    public float speed = 7.0f;
    private CharacterController myCharacterController;
    //[SerializeField] private Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        myCharacterController = GetComponent<CharacterController>();
        
    }

    // Update is called once per frame
    void Update()
    {
        myCharacterController.SimpleMove(new Vector3(0f, 0f, 0f));
        myCharacterController.Move(transform.forward * speed * Time.deltaTime);
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag.Equals("coin"))
        {
            Destroy(other.gameObject);
        }
         if(other.gameObject.tag.Equals("water"))
         {
            myCharacterController.SimpleMove(new Vector3(0f, 0f, 0f));
            myCharacterController.Move(transform.forward * (speed-5) * Time.deltaTime);
        }
    }
}
