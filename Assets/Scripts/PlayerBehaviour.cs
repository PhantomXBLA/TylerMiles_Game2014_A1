using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehaviour : MonoBehaviour
{
    //Touch touch;
    //public GameObject player;
    Touch touch;

    Rigidbody2D body;
    Animator animator;

    Vector2 jumpForce = new Vector2(0, 1000);
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        body = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.y <= -2.7)
        {
            animator.SetBool("isGrounded", true);
            
        }
        else
        {
            animator.SetBool("isGrounded", false);
        }
        if(Input.touchCount > 0)
        {
             touch = Input.GetTouch(0);

            switch (touch.phase)
            {
                case TouchPhase.Began:
                    body.AddForce(jumpForce);
                    animator.SetTrigger("JumpTrigger");
                    Debug.Log("screen pressed");
                    break;

                case TouchPhase.Ended:
                    Debug.Log("nothing is touching the screen big man");
                    break;
            }
        }     
    }
}
