using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class PlayerBehaviour : MonoBehaviour
{
    Touch touch;
    //public GameObject player;

    Rigidbody2D body;
    Animator animator;

    Vector2 direction;
    Vector2 touchStart;

    bool isGrounded = true;
    bool canSlide = true;
    bool canJump = true;

    bool sliding = false;

    public float lives;
    float score;
    float speedMultiplier;

    public TextMeshProUGUI scoreLabel;
    public TextMeshProUGUI livesLabel;

    public GameObject ground;

    public AudioSource coinPickup;
    public AudioSource jumpSound;
    public AudioSource landSound;
    public AudioSource deathSound;
    public AudioSource hitSound;


    Vector2 jumpForce = new Vector2(0, 1000);
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        body = GetComponent<Rigidbody2D>();

        Application.targetFrameRate = 60; // From Unity Documentation -> Sets frame rate on mobile devices (or emulators) to 60
    }

    void jump()
    {
        if (isGrounded)
        {
            isGrounded = false;
            jumpSound.Play();
            animator.SetBool("isGrounded", false);
            body.AddForce(jumpForce);
            animator.SetTrigger("JumpTrigger");
            Debug.Log("jump");
        }
    }

    IEnumerator slideCooldown()
    {
        
        yield return new WaitForSeconds(0.5f);
        sliding = false;
        canSlide = true;
        canJump = true;
        
    }

    void slide()
    {
        sliding = true;
        animator.SetTrigger("SlideTrigger");
        Debug.Log("slide initiated");
        canSlide = false;
        canJump = false;
        StartCoroutine(slideCooldown());
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "ground")
        {
            if(isGrounded == false){
                landSound.Play();
            }

            isGrounded = true;
            
            animator.SetBool("isGrounded", true);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "enemy" && sliding == false)
        {
            lives--;
            deathSound.Play();
        }

        if (collision.gameObject.tag == "enemy" && sliding == true)
        {
            Destroy(collision.gameObject);
            hitSound.Play();
        }

        if (collision.gameObject.tag == "pickup")
        {
            score += 250;
            coinPickup.Play();
            Destroy(collision.gameObject);
        }
    }


    // Update is called once per frame
    void Update()
    {

        if(lives == 0)
        {
            SceneManager.LoadScene(3);
        }

        speedMultiplier = ground.GetComponent<BackgroundController>().horizontalSpeed;
        scoreLabel.text = "Score: " + score.ToString("f0");
        livesLabel.text = "Lives: " + lives.ToString("f0");

        score += (Time.deltaTime*speedMultiplier);
        //Debug.Log(touchStart);

        if (Input.touchCount > 0)
        {
             touch = Input.GetTouch(0);
            Debug.Log(direction);
            switch (touch.phase)
            {
                case TouchPhase.Began:
                    touchStart = touch.position;

                    break;

                case TouchPhase.Moved:
                    direction = touch.position - touchStart; //From Unity Documentation -> Gets distance of swipe from original touch position which can determine which way the player swiped

                    if(direction.y > 150 && isGrounded && canJump)
                    {
                        jump();

                    }

                    else if(direction.y < 0 && isGrounded && canSlide)
                    {
                        slide();
                    }


                    break;

                case TouchPhase.Ended:
                    Debug.Log("nothing is touching the screen big man");
                    touchStart = Vector2.zero;
                    touch.position = Vector2.zero;
                    direction = Vector2.zero;
                   
                    break;

                    
            }
        }     
    }
}
