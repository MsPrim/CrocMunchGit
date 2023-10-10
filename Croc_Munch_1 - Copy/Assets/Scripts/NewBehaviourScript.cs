using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//This script manages the crocodile's movement and keeps it in bounds

public class NewBehaviourScript : MonoBehaviour
{
    public float horizontalInput;
    public float verticalInput;
    public float speed = 5.0f;
    public float xRange = 15;
    public float yRange = 18;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        GetComponent<Rigidbody>().velocity = Vector3.zero;

        MoveGameObject();
        KeepInBound();

    }
    
  
 private void MoveGameObject()
    {
        //Make the player move
        var horizontalInput = Input.GetAxisRaw("Horizontal");
        var verticalInput = Input.GetAxisRaw("Vertical");

        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.D))
        {
           transform.Translate(Vector2.right * horizontalInput * Time.deltaTime * speed);
        }

        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.S))
        {
            transform.Translate(Vector2.up * verticalInput * Time.deltaTime * speed);
        }
    }

    private void KeepInBound()
    {
        //Keep player in x axis bounds
        if (transform.position.x < -xRange)
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }
        if (transform.position.x > xRange)
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }
    }
}
