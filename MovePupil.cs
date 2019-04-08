﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MovePupil : MonoBehaviour
{
    // Start is called before the first frame update
    private Rigidbody2D rbd;
    public int speed;
    private Animator anim;
   // private float walk = 0f;
    //private CollisionFlags m_CollisionFlags;
    //bool isCollision = false;
    //string text = "YOU HIT ME";
    //float wide = 0f;
    //float high = 0f;
    // Use this for initialization
    void Start()
    {
        rbd = gameObject.GetComponent<Rigidbody2D>();
        anim = gameObject.GetComponent<Animator>();
        speed = 2;
        
    }

    // Update is called once per frame
    void Update()
    {
        //walk = Input.GetAxis("Horizontal");
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            
            rbd.velocity = new Vector2(-speed, rbd.velocity.y);
            transform.localScale = new Vector2(-0.45f, 0.45f);
            anim.SetTrigger("walk");
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            rbd.velocity = new Vector2(speed, rbd.velocity.y);
            transform.localScale = new Vector2(0.45f, 0.45f);
            anim.SetTrigger("walk");
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            rbd.velocity = new Vector2(rbd.velocity.y, speed);
            anim.SetTrigger("walk");
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            rbd.velocity = new Vector2(rbd.velocity.y, -speed);
            anim.SetTrigger("walk");
        }
    }

   /* private void OnControllerColliderHit(ControllerColliderHit hit)
    {
        Rigidbody body = hit.collider.attachedRigidbody;
        //dont move the rigidbody if the character is on top of it
        if (m_CollisionFlags == CollisionFlags.Below)
        {
            return;
        }

        if (body == null || body.isKinematic)
        {
            return;
        }
        body.AddForceAtPosition(rbd.velocity * 0.1f, hit.point, ForceMode.Impulse);
    }*/

    void OnCollisionEnter2D(Collision2D other)
    {
        //Check the provided Collider2D parameter other to see if it is tagged "PickUp", if it is...
        if (other.gameObject.CompareTag("BOX"))
        {
            Debug.Log("PUPIL collided with BOX");
            SceneManager.LoadScene(4);
            //isCollision = true;
            //other.gameObject.SetActive(false);
        }
        if (other.gameObject.CompareTag("RADIO"))
        {
            Debug.Log("PUPIL collided with RADIO");
            SceneManager.LoadScene(5);
            //isCollision = true;
            //other.gameObject.SetActive(false);
        }
    }

    /*void OnGUI()
    {
        if (isCollision)
        {
            //GUI.TextArea(new Rect((Screen.width / 2) - wide, (Screen.height / 2) - high, (wide * 2), (high * 2)), text);
            GUI.TextArea(new Rect(260, 60, 400, 300), text);
        }
    }*/
}
