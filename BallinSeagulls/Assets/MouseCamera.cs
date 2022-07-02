using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseCamera : MonoBehaviour
{
    public GameObject target;
    public float xOffset, yOffset, zOffset;
    public float speed = 10f;
    // Update is called once per frame
    void Start()
    {
        transform.position = target.transform.position + new Vector3 (xOffset, yOffset, zOffset);
        transform.LookAt(target.transform.position);
    }

    void Update()
    {
       
       //transform.position = target.transform.position + new Vector3 (xOffset, yOffset, zOffset);
       if (Input.GetAxis("Mouse X") > 0)
       {
           transform.position += new Vector3(Input.GetAxisRaw("Mouse X") + Time.deltaTime * speed - xOffset, 0.0f, Input.GetAxisRaw("Mouse Y") + Time.deltaTime * speed);
       }
       else if (Input.GetAxis("Mouse X") < 0)
       {
           transform.position += new Vector3(Input.GetAxisRaw("Mouse X") + Time.deltaTime * speed - xOffset, 0.0f, Input.GetAxisRaw("Mouse Y") + Time.deltaTime * speed);
       }
       else
       {
           transform.position = target.transform.position + new Vector3 (xOffset, yOffset, zOffset);
           transform.LookAt(target.transform.position);
       }

       //transform.LookAt(target.transform.position);
    }
}
