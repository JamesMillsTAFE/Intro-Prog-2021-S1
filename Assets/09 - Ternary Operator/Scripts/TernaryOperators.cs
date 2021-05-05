using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TernaryOperators : MonoBehaviour
{
    [SerializeField] private bool isSprinting = false;
    [SerializeField] private bool isCrouching = false;
    [SerializeField] private float moveSpeed = 1;
    [SerializeField] private float sprintSpeed = 2;
    [SerializeField] private float crouchSpeed = .5f;

    // Update is called once per frame
    void Update()
    {
        // Unary Operator assignment.
        //float speed = 0;
        //if (isSprinting) speed = sprintSpeed;
        //else speed = moveSpeed;

        // Single Ternary operator assignment
        // condition ? true : false
        // ? = if - this is the question
        // : = else
        // true = if the condition was true we do this
        // false = if the condition was false we do this
        //float speed = isSprinting ? sprintSpeed : moveSpeed;

        // Nested Ternary operator assignment
        // Ternary operators can be placed within each other to chain them
        // like this when we need to handle more than one case
        // The standard is to only have maximum 3 ternary operators nested
        //float speed = isCrouching ? crouchSpeed : isSprinting ? sprintSpeed : moveSpeed;

        //float speed = GetMoveSpeed();
        //transform.position += transform.forward * speed * Time.deltaTime;

        // Because when you pass in information as a parameter it is setting
        // the value of the parameter, you can use a ternary operator!
        Move(isCrouching ? crouchSpeed : isSprinting ? sprintSpeed : moveSpeed);
    }

    private void Move(float _speed) 
        => transform.position += transform.forward * _speed * Time.deltaTime;

    // Ternary operators can also be used in return statements!
    private float GetMoveSpeed() 
        => isCrouching ? crouchSpeed : isSprinting ? sprintSpeed : moveSpeed;
}
