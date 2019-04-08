using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class Touchmove : MonoBehaviour
{
    float dirX;
    float dirY;
    Rigidbody2D rb;
    Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D> ();
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        dirX = CrossPlatformInputManager.GetAxis("Horizontal");
        dirY = CrossPlatformInputManager.GetAxis("Vertical");
        rb.velocity = new Vector2(dirX * 20, dirY * 20);
        //rb.velocity = new Vector2(0, dirY * 10);
        anim.SetTrigger("walk");
        /*if( < 0)
        {
            transform.localScale = new Vector2(-0.45f, 0.45f);
        }
        transform.localScale = new Vector2(0.45f, 0.45f);*/
    }
}
