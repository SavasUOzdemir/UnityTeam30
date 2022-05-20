using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement2 : MonoBehaviour
{
    private Animator anims;
    Rigidbody2D rb;

    float speed = 5f;

    private void Awake() {
        
        rb = GetComponent<Rigidbody2D>();
        anims = GetComponent<Animator>();

    }

    private void Update() 
    {
        hareket ();
        sinirlandirma ();
    }

    private void hareket ()
    {
        float h = Input.GetAxis("Horizontal");						 
											    
        float hiz = h * speed;								   
											    	
        rb.velocity = new Vector2(hiz, rb.velocity.y);

        anims.SetFloat("speedParam", h);
    }

    private void sinirlandirma ()
    {
        if (transform.position.x < -8.25f)
        {
            transform.position = new Vector2 (-8.25f, transform.position.y);
        }
    }
}
