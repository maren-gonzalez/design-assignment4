using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    private CharacterController characterController;
    public float speed;

    public CollectibleManager cm;
    
    // Start is called before the first frame update
    void Start()
    {
        characterController = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 movement = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
        characterController.Move(movement * (speed * Time.deltaTime));
    }

    void OnTriggerEnter(Collider other)
    {
        Destroy(other.gameObject);
        cm.pumpkinCount ++;
    }
}
