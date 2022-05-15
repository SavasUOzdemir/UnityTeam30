using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement2 : MonoBehaviour
{
    Rigidbody2D rb;

    float speed = 5f;

    private void Awake() {
        
        rb = GetComponent<Rigidbody2D>();

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
    }

    private void sinirlandirma ()
    {
        if (transform.position.x < -10f)
        {
            transform.position = new Vector2 (-10f, transform.position.y);
        }
    }
}
