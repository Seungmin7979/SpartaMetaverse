using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    [SerializeField] private float moveSpeed = 5f;

    private Rigidbody2D rb;
    private Vector2 movement;

    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        // 1. 이동 입력
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");
        movement.Normalize();
    }

    void FixedUpdate()
    {
        // 평면 이동
        rb.velocity = movement * moveSpeed;
    }

    void LateUpdate()
    {
        // 캐릭터 벽 안나가게 설정
        Vector2 pos = transform.position;

        pos.x = Mathf.Clamp(pos.x, -17.6f, 21.6f);    // X 경계
        pos.y = Mathf.Clamp(pos.y, -9.2f, 12.9f);    // Y 경계

        transform.position = pos;
    }
}
