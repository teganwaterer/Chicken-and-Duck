using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TW_Movement : MonoBehaviour
{
    [SerializeField]
    private float speed = 0.5f;

    [SerializeField]
    private float jumpForce = 5f;

    

    private bool isGrounded;
    private Rigidbody rb;

    void Start()
    {
        // Get the Rigidbody component
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        // Movement
        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");

        Vector3 moveDirection = new Vector3(x, 0, y).normalized;
        transform.Translate(speed * Time.deltaTime * moveDirection);

        // Jump
        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            isGrounded = false;
            
        }


    }

    private void OnCollisionEnter(Collision collision)
    {
        // Check if the player is on the ground
        if (collision.contacts.Length > 0 && collision.gameObject.CompareTag("Ground"))
        {
            isGrounded = true;
        }
    }
}

