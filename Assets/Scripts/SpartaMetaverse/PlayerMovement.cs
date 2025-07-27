using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    [SerializeField] private float moveSpeed = 5f;

    private Rigidbody2D rb;
    private Vector2 movement;
    private Vector2 dir = Vector2.down;

    private PlayerAnimationController animator;

    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<PlayerAnimationController>();
    }

    void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");
        movement = new Vector2(movement.x, movement.y).normalized;


        if (Mathf.Approximately(movement.x, 0) && Mathf.Approximately(movement.y, 0))
        {
            animator.IsMoving(false);
        }
        else
        {
            dir = movement;
            animator.IsMoving(true);
        }
        animator.FaceX(dir.x);
        animator.FaceY(dir.y);
        
    }

    void FixedUpdate()
    {

        rb.velocity = movement * moveSpeed;
    }

    void LateUpdate()
    {
  
        Vector2 pos = transform.position;

        pos.x = Mathf.Clamp(pos.x, -17.6f, 21.6f);    
        pos.y = Mathf.Clamp(pos.y, -9.2f, 12.9f);    

        transform.position = pos;
    }
}
