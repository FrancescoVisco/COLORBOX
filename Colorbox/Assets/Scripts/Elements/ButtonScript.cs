using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonScript : MonoBehaviour
{

    public SpriteRenderer spriteRenderer;
    public Sprite Button;
    public Sprite ButtonPressed;

    public bool ButtonRed;
    public bool ButtonBlue;
    public bool ButtonYellow;

    public bool pressed = false;

    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        spriteRenderer.sprite = Button;
    }

    void Update()
    {
        if(ButtonRed == true)
        {
           if(GameObject.Find("Colorbox").GetComponent<CharacterController>().Red == true)
           {
              spriteRenderer.sprite = ButtonPressed;              
           }
           else
           {
              spriteRenderer.sprite = Button;
           }
        }

        if(ButtonBlue == true)
        {
           if(GameObject.Find("Colorbox").GetComponent<CharacterController>().Blue == true)
           {
              spriteRenderer.sprite = ButtonPressed;              
           }
           else
           {
              spriteRenderer.sprite = Button;
           }
        }

        if(ButtonYellow == true)
        {
           if(GameObject.Find("Colorbox").GetComponent<CharacterController>().Yellow == true)
           {
              spriteRenderer.sprite = ButtonPressed;              
           }
           else
           {
              spriteRenderer.sprite = Button;
           }
        }        

        if(spriteRenderer.sprite == ButtonPressed)
        {
            pressed = true;
        }
        else
        {
            pressed = false;
        }
    }
}
