using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float forwardSpeed;
    [SerializeField] private float sideSpeed;
   
    private Rigidbody2D rb;
    private Vector2 movement;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float forwardMovement = Input.GetAxisRaw("Vertical");
        float sideMovement = Input.GetAxisRaw("Horizontal");

        movement.x = sideMovement;
        movement.y = forwardMovement;
        movement.Normalize();      
    }

    private void FixedUpdate()
    {
        rb.velocity = new Vector2(movement.x * sideSpeed, movement.y * forwardSpeed) * Time.fixedDeltaTime; 
    }
}
