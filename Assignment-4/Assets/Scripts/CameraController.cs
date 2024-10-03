using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    private CharacterController characterController;
    public float speed;
    public float rotationSpeed;
    
    // Start is called before the first frame update
    void Start()
    {
        characterController = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        
        float vertical = Input.GetAxis("Vertical");
        transform.Translate(Vector3.forward * vertical * speed * Time.deltaTime);

        //get turning input + transform position
        float horizontal = Input.GetAxis("Horizontal");
        transform.Rotate(Vector3.up * horizontal * rotationSpeed * Time.deltaTime);
     
    }
}
