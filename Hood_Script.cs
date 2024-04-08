using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using System.Security.Cryptography;
using Unity.VisualScripting;
using UnityEngine;

public class Hood_Script : MonoBehaviour
{
    private float Horizontal;
    private float Vertical;
    private float speed = 8f;
    private float JumpingPower = 15f;
    private bool isFacingRight = true;

    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private Transform GroundCheck;
    [SerializeField] private LayerMask groundLayer;

    // Start is called before the first frame update
    void Start()
    {
          
    }

    // Update is called once per frame
    void Update()
    {
        Horizontal = Input.GetAxisRaw("Horizontal");
        Vertical = Input.GetAxisRaw("Vertical");
    }
    void FixedUpdate()
    {
        rb.velocity = new Vector2(Horizontal * speed,rb.velocity.y);
        


    }
    private void Flip()
    {
        if (Horizontal > -1 && isFacingRight)
        {
                     
        }
    }



}
    