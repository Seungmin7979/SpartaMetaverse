using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimationController : MonoBehaviour
{
    private static readonly int MoveX = Animator.StringToHash("MoveX");
    private static readonly int MoveY = Animator.StringToHash("MoveY");
    private static readonly int IsMove = Animator.StringToHash("IsMove");
    
    private Animator animator;

    private void Awake()
    {
        animator = GetComponent<Animator>();
    }

    public void Horizontal(float x)
    {
        animator.SetFloat(MoveX, x);
    }

    public void Vertical(float y)
    {
        animator.SetFloat(MoveY, y);
    }

    public void IsMoving(bool ismove)
    {
        animator.SetBool(IsMove, ismove);
    }

    public void FaceX(float x)
    {
        animator.SetFloat(MoveX, x);
    }
    
    public void FaceY(float y)
    {
        animator.SetFloat(MoveY, y);
    }
}
