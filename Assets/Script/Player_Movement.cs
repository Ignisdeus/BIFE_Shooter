using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Player_Movement : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
        defaultSpeed = speed;
        camera.transform.rotation = Quaternion.Euler(Vector3.zero);
    }
    public GameObject camera; 
    float defaultSpeed = 0; 
    public float speed = 5.0f;
    public float  rotationSpeed = 120f;
    public KeyCode sprint;
    public float sprintMod = 1.5f; 
    void Update()
    {
        Movement();
        CameraMovement(); 
       //  
    }
    public Vector2 cameraLimits; 
    void Movement(){
        if( Input.GetKey(sprint)){ 
            speed = defaultSpeed * sprintMod;    
        }else{
            speed = defaultSpeed; 
        }
        float fwd = Input.GetAxisRaw("Vertical"); 
        transform.Translate(Vector3.forward * fwd * speed * Time.deltaTime);
    } 
    void CameraMovement(){

        float mouseRotation = Input.GetAxisRaw("Mouse X");
        transform.Rotate(Vector3.up * rotationSpeed * mouseRotation * Time.deltaTime);
        float mouseRotationY = Input.GetAxisRaw("Mouse Y");
        camera.transform.Rotate(Vector3.right * - rotationSpeed * mouseRotationY * Time.deltaTime);
    } 
}
