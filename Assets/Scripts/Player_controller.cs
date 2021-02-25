using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_controller : MonoBehaviour
{
    public float jumpForce = 2.0f;
    public float speed = 3.0f;


    private Rigidbody2D rgbd;
    private Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        rgbd = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        animator.SetBool("OnGround", true);
    }

    // Update is called once per frame
    void Update()
    {
        rgbd.velocity = new Vector2(Input.GetAxis("Horizontal") * speed, rgbd.velocity.y) ;

        if (Input.GetButtonDown("Jump")) {
            rgbd.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
            animator.SetBool("OnGround", false);
        }   
        
    }
}
