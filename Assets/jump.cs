using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;


public class jump : MonoBehaviour
{
    private Vector3 jumper;
    private Rigidbody rb;
    private bool onFloor;
    [SerializeField] private float speed = 50f;
    [SerializeField] private float rotSpeed = 50f;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        jumper = new Vector3(0.0f, 2.0f, 0.0f);


    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Space) && onFloor == true) 
        {
            rb.AddForce(jumper *3.5f, ForceMode.Impulse);
            onFloor = false;
        }

        Vector3 positionUpdate = transform.position + Input.GetAxis("Vertical") * transform.forward * speed * Time.deltaTime;
        transform.Rotate(new Vector3(0, Input.GetAxis("Horizontal") * rotSpeed * Time.deltaTime, 0));
        transform.position = positionUpdate;
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "floor")
        {
            onFloor = true;
        }
    }
}
