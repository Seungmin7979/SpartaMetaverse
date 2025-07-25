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
        // 1. �̵� �Է�
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");
        movement.Normalize();
    }

    void FixedUpdate()
    {
        // ��� �̵�
        rb.velocity = movement * moveSpeed;
    }

    void LateUpdate()
    {
        // ĳ���� �� �ȳ����� ����
        Vector2 pos = transform.position;

        pos.x = Mathf.Clamp(pos.x, -17.6f, 21.6f);    // X ���
        pos.y = Mathf.Clamp(pos.y, -9.2f, 12.9f);    // Y ���

        transform.position = pos;
    }
}
