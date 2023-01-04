using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun_Base : MonoBehaviour
{
    public GameObject muzzle, bullet; 
    public KeyCode fire; 
    float timer = 10f;
    public float fireRate = 1f;
    public float force = 500f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        timer += Time.deltaTime; 
        if(Input.GetKey(fire)&& timer >= fireRate){
            timer =0f; 
            GameObject x = Instantiate(bullet, muzzle.transform.position, Quaternion.identity);
            Vector3 fwd = muzzle.transform.forward; 
            x.GetComponent<Rigidbody>().AddForce(fwd * force); 
        } 
    }
}
