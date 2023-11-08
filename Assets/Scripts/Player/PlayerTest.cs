using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerTest : MonoBehaviour
{
    [HideInInspector] public CharacterController characterController;
    public float moveSpeed;

    void Start()
    {
        characterController = GetComponent<CharacterController>();   
    }

    // Update is called once per frame
    void Update()
    {
        // Character movement
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");
        Vector3 moveDirection = transform.TransformDirection(new Vector3(horizontalInput, 0, verticalInput) * moveSpeed);

        characterController.Move(moveDirection * Time.deltaTime);
    }
}
