using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class onhit : MonoBehaviour
{
    public string targetTag;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    }
    private void OnTriggerEnter(Collider coll)
    {
        if (coll.gameObject.tag == targetTag)
        {
            Destroy(coll.gameObject, 0.1f);
        }
    }
    private void OnCollisionEnter(Collision coll)
    {
        if (coll.gameObject.tag == targetTag)
        {
            Destroy(coll.gameObject, 0.1f);
        }
    }
}
