using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
<<<<<<< Updated upstream

{
    public float moveSpeed = 5f;
    public Rigidbody2D rb;

    Vector2 movement;
=======
{
    public float moveSpeed = 5f;
>>>>>>> Stashed changes

    // Update is called once per frame
    void Update()
    {
        
<<<<<<< Updated upstream
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");
    }

    void FixedUpdate()
    {
        rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime); 
    }
}
=======
    }
}
>>>>>>> Stashed changes
