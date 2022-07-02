using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
   
//    public CharaterController controller; 

//    public float speed = 6f;

//    void Update()
//    {
//     float horizontal = Iput.GetAxisRaw("Horizontal");
//     float vertical = Input.GetAxisRaw("Vertical");
//     Vector3 direction = new Vector3 (horizontal, 0f, vertical).normalizeed;

//     if (direction.magnitude >= 0.1f )
//     {
//             controller.Move(direction * speed * Time.deltaTime);
//     }
//    }
   
   
   
   
   
   
   
   
   
    public Rigidbody rb;
    //rb = GetComponet,Rigidbody>();
    public float moveSpeed = 10f;
    private float xInput;
    private float yInput;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        ProcessInputs();
    }
    private void FixedUpdate()
    {
        Move();
    }
    private void ProcessInputs()
    {
        xInput = Input.GetAxis("Horizontal");
        yInput = Input.GetAxis("Vertical");
    }
    private void Move(){
        rb.AddForce(new Vector3(xInput, 0f, yInput)*moveSpeed);
    }
}
