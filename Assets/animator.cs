using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animator : MonoBehaviour
{
    [SerializeField] private float speed = 50f;
    [SerializeField] private float rotSpeed = 50f;
    private Animator animations;
    private Rigidbody rb;
   
    // Start is called before the first frame update
    void Start()
    {
        animations = GetComponent<Animator>();
        rb = gameObject.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.T))
        {
            animations.SetTrigger("time");
        };
        if (Input.GetKeyDown(KeyCode.W)) 
        { 
            animations.SetBool("walk",true);
        }
        if (Input.GetKeyUp(KeyCode.W))
        {
            animations.SetBool("walk",false);
        };
        if (Input.GetKeyDown(KeyCode.S))
        {
            animations.SetBool("back", true);
        }
        if (Input.GetKeyUp(KeyCode.S))
        {
            animations.SetBool("back", false);
        }
        if (Input.GetKey(KeyCode.W) == true)
        {
            rb.AddForce(transform.forward * speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.S) == true)
        {
            rb.AddForce(transform.forward * -speed * Time.deltaTime);
        };
        transform.Rotate(new Vector3(0, Input.GetAxis("Horizontal") * rotSpeed * Time.deltaTime, 0));
    }
}
