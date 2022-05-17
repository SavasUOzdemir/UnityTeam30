using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    Rigidbody2D rb;

    bool isClimbing = false;

    bool isJumping = false;

    float speed = 2f;

    float leftCorner = -10f;

    float tirmanma = 0f;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        hareket();
    }

    private void sinirlandirma()
    {
        if (transform.position.x < leftCorner)
        {
            transform.position = new Vector2(leftCorner, transform.position.y);
        }
    }
    private void hareketRight ()
    {
        float h = 1f;
        float hiz = h * speed;
        rb.velocity = new Vector2(hiz, rb.velocity.y);
    }

     private void hareketLeft ()
    {
        float h = -1f;
        float hiz = h * speed;
        rb.velocity = new Vector2(hiz, rb.velocity.y);
    }

     private void hareketUp ()
    {
        float h = 1f;
        float hiz = h * speed;
        
        tirmanma = transform.position.x % 100;
            
            if (tirmanma < 3 && tirmanma >= 0)
           
        {
            rb.velocity = new Vector2(rb.velocity.x, hiz);

            isClimbing = true;
        }
        else 
        {
            isJumping = true;
        }
    }

    private void hareketDown ()
    {
        float h = -1f;
        float hiz = h * speed;
        rb.velocity = new Vector2(rb.velocity.x, hiz);
    }
    private void hareket()
    {
        isJumping = false;

        isClimbing = false;
        
        sinirlandirma();

        if (Input.GetAxis("Horizontal") > 0)
        {
            hareketRight();
        }

        else if (Input.GetAxis("Horizontal") < 0)
        {
            hareketLeft();
        }

        else if (Input.GetAxis("Vertical") > 0)
        {
            hareketUp();
        }

        else if (Input.GetAxis("Vertical") < 0)
        {
            hareketDown();
        }
        
        
    }
}
