using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
//using Cinemachine


public class ThirdPersonMovement : MonoBehaviour
{
// public Action<Vector2> OnMovementInput;
// public Action<Vector3> OnMovementDirectionInput;

// void Start()
// {
//    // Cursor.lockstate =CursorLockMode.Locked;

// }
// void Update ()
// {
//     GetMovementInput();
//     GetMovementDirection();
// }

// private void GetMovementDirection()
// {
//     var cameraForwardDirection = Camera.main.transform.forward;
//     var directionToMoveIn = Vector3.Scale(cameraForwardDirection,(Vector3.right + Vector3.forward));
//     OnMovementDirectionInput?.Invoke(directionToMoveIn);
// }

// private void GetMovementInput()
// {
//     Vector2 input = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
//     OnMovementInput?.Invoke(input);
// }




public CharacterController controller;
public Transform cam;
//public Rigidbody rb;

   public float speed = 6f;
   public float turnSmoothTime = 0.1f;
   float turnSmootVelocity; 

    public Vector3 velocity;
    public float gravity; 

    public Transform groundCheck;
    public float  groundDistance = 0.4f;
    public LayerMask groundMask;
    bool isGrounded;



   void Start()
   {
    //controller = gameObject.AddComponent<CharacterController>();
   }

   void Update()
   {
    isGrounded = Physics.CheckSphere(groundCheck.position, groundDistance, groundMask);

    // if (isGrounded && velocity.y < 0)
    // {
    //     velocity.y = -20f;
    // }
    velocity.y = -20f;

    float horizontal = Input.GetAxisRaw("Horizontal");
    float vertical = Input.GetAxisRaw("Vertical");
    Vector3 direction = new Vector3 (horizontal, 0f, vertical).normalized;

    if (direction.magnitude >= 0.1f )
    {
            float targetAngle = Mathf.Atan2(direction.x, direction.z) * Mathf.Rad2Deg + cam.eulerAngles.y;
            float angle = Mathf.SmoothDampAngle(transform.eulerAngles.y, targetAngle, ref turnSmoothTime, turnSmoothTime);
            transform.rotation = Quaternion.Euler(0f, angle, 0f);

            Vector3 moveDir = Quaternion.Euler(0f, targetAngle, 0f)* Vector3.forward;
            controller.Move(moveDir.normalized * speed * Time.deltaTime);

    }
    controller.Move(velocity * Time.deltaTime);

    velocity.y += gravity * Time.deltaTime;

   }
    
}
