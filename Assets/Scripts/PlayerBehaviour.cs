using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehaviour : MonoBehaviour
{
    Touch touch;
    //public GameObject player;

    Rigidbody2D body;
    Animator animator;

    private Vector3 m_touchesEnded;

    Vector2 direction;
    Vector2 touchStart;

    bool isGrounded = true;
    bool canSlide = true;

    float lives;

    

    Vector2 jumpForce = new Vector2(0, 1000);
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        body = GetComponent<Rigidbody2D>();
    }

    void JumpOrSlide()
    {
        
      
    }

    void jump()
    {
        if (isGrounded)
        {
            isGrounded = false;
            animator.SetBool("isGrounded", false);
            body.AddForce(jumpForce);
            animator.SetTrigger("JumpTrigger");
            Debug.Log("jump");
        }
    }

    IEnumerator slideCooldown()
    {
        yield return new WaitForSeconds(0.5f);
        canSlide = true;
    }

    void slide()
    {
        animator.SetTrigger("SlideTrigger");
        Debug.Log("slide initiated");
        canSlide = false;
        StartCoroutine(slideCooldown());
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "ground")
        {
            isGrounded = true;
            animator.SetBool("isGrounded", true);
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "ground")
        {
            isGrounded = false;
            
        }
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log(touchStart);

        if (Input.touchCount > 0)
        {
             touch = Input.GetTouch(0);
            Debug.Log(direction);
            switch (touch.phase)
            {
                case TouchPhase.Began:
                    //body.AddForce(jumpForce);
                    //animator.SetTrigger("JumpTrigger");
                    //Debug.Log("screen pressed");

                    touchStart = touch.position;

                    break;

                case TouchPhase.Moved:
                    direction = touch.position - touchStart;

                    if(direction.y > touchStart.y && isGrounded)
                    {
                        jump();

                    }

                    else if(direction.y < 0 && isGrounded && canSlide)
                    {
                        slide();
                    }


                    break;

                case TouchPhase.Ended:
                    //Debug.Log("nothing is touching the screen big man");
                    //touchStart = Vector2.zero;
                    //touch.position = Vector2.zero;
                    //direction = Vector2.zero;
                   
                    break;

                    
            }
        }     
    }
}
