using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterController : MonoBehaviour
{
    public Rigidbody2D rb;
    public float movementSpeed;
    public float JumpHeight;
    public bool grounded;
    public Transform groundCheck;
    public LayerMask groundLayer;

    public bool Red;
    public bool Yellow;
    public bool Blue;

    public SpriteRenderer spriteRenderer;
    public Sprite S_White;
    public Sprite S_Red;
    public Sprite S_Blue;
    public Sprite S_Yellow;
    public Sprite S_Orange;
    public Sprite S_Purple;
    public Sprite S_Green;
    public Sprite S_Empty;

    private void Start()
    {
        Red = false;
        Yellow = false;
        Blue = false;
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    private void Update()
    {
        //Movimento
        grounded = Physics2D.OverlapCircle(groundCheck.position, 0.2f, groundLayer);
        rb.velocity = new Vector2(Input.GetAxis("Horizontal") * movementSpeed * Time.deltaTime, rb.velocity.y);
        
        if(grounded)
        {
            if(Input.GetButtonDown("Jump"))
            {
               rb.AddForce(new Vector3(0, JumpHeight), ForceMode2D.Impulse);    
            }
        }

        //Gestione cambio sprite
        if(Red == true && Blue == false && Yellow == false)
        {
           spriteRenderer.sprite = S_Red; 
        }

        if(Red == false && Blue == true && Yellow == false)
        {
           spriteRenderer.sprite = S_Blue; 
        }       

        if(Red == false && Blue == false && Yellow == true)
        {
           spriteRenderer.sprite = S_Yellow; 
        }    

        if(Red == true && Blue == true && Yellow == true)
        {
           spriteRenderer.sprite = S_White; 
        }  

        if(Red == true && Blue == true && Yellow == false)
        {
           spriteRenderer.sprite = S_Purple; 
        } 

        if(Red == true && Blue == false && Yellow == true)
        {
           spriteRenderer.sprite = S_Orange; 
        } 

        if(Red == false && Blue == true && Yellow == true)
        {
           spriteRenderer.sprite = S_Green; 
        } 

        if(Red == false && Blue == false && Yellow == false)
        {
           spriteRenderer.sprite = S_Empty; 
        } 
    }
    
    //Gestione collisione pulsanti
    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.CompareTag("Button"))
        {
            if(other.gameObject.GetComponent<ButtonScript>().ButtonRed == true)
            {
                if(other.gameObject.GetComponent<ButtonScript>().pressed == true)
                {
                    Red = false;
                }
                else
                {
                    Red = true;
                }
            }

            if(other.gameObject.GetComponent<ButtonScript>().ButtonBlue == true)
            {
                if(other.gameObject.GetComponent<ButtonScript>().pressed == true)
                {
                    Blue = false;
                }
                else
                {
                    Blue = true;
                }
            }

            if(other.gameObject.GetComponent<ButtonScript>().ButtonYellow == true)
            {
                if(other.gameObject.GetComponent<ButtonScript>().pressed == true)
                {
                    Yellow = false;
                }
                else
                {
                    Yellow = true;
                }
            }
        }
    }   
}