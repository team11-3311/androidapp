using System.Collections;
using System.Collections.Generic;
using UnityStandardAssets.CrossPlatformInput;
using UnityEngine;
using UnityEngine.SceneManagement;


public class movepupil_art : MonoBehaviour
{

    private Rigidbody2D rb;
    public int speed;
    private Animator anim;
    float dirX;
    float dirY;
    GameObject key_info;
    key_info_script kis;


    // Start is called before the first frame update
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
        anim = gameObject.GetComponent<Animator>();
        speed = 2;
        key_info = GameObject.FindGameObjectWithTag("key_info");
        kis = key_info.GetComponent<key_info_script>();
    }



    // Update is called once per frame
    void Update()
    {

        dirX = CrossPlatformInputManager.GetAxis("Horizontal");
        dirY = CrossPlatformInputManager.GetAxis("Vertical");
        rb.velocity = new Vector2(dirX * 20, dirY * 20);
        //rb.velocity = new Vector2(0, dirY * 10);
        anim.SetTrigger("walk");
        



    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        
        if (collision.gameObject.CompareTag("door1"))
        {
            SceneManager.LoadScene(7);
        }

        if (collision.gameObject.CompareTag("room2_door"))
        {
            SceneManager.LoadScene(5);
        }

        if (collision.gameObject.CompareTag("room2_table"))
        {
            SceneManager.LoadScene(8);
        }

        if (collision.gameObject.CompareTag("room1_safe"))
        {
            SceneManager.LoadScene(9);
        }

        if (collision.gameObject.CompareTag("room1_door2"))
        {
            if (kis.has_key != 1)
            {
                SceneManager.LoadScene(11);
            }

            else
            {
                SceneManager.LoadScene(12);
            }
            
        }

        if (collision.gameObject.CompareTag("room3_door1"))
        {
            SceneManager.LoadScene(13);
        }

        if (collision.gameObject.CompareTag("collector"))
        {
            SceneManager.LoadScene(18);
        }

        if (collision.gameObject.CompareTag("KING"))
        {
            SceneManager.LoadScene(16);
        }

        if (collision.gameObject.CompareTag("QUEEN"))
        {
            SceneManager.LoadScene(17);
        }



    }
}
