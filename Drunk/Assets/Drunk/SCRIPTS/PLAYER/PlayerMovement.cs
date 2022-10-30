using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float normalSpeed;
    [SerializeField] private float sprintSpeed;
    [SerializeField] private KeyCode runKey;
    Rigidbody rb;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        PlayerMove();
    }

    private void PlayerMove()
    {
        float playerMoveSpeed = IsPlayerSprinting() ? sprintSpeed : normalSpeed;

        Vector2 playerVelocity = new Vector2(Input.GetAxis("Horizontal") * playerMoveSpeed, Input.GetAxis("Vertical") * playerMoveSpeed);

        rb.velocity = transform.rotation * new Vector3(playerVelocity.x, rb.velocity.y, playerVelocity.y);
    }

    private bool IsPlayerSprinting()
    {
        return Input.GetKey(runKey);
    }

}
