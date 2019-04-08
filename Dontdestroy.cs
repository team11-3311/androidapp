using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dontdestroy : MonoBehaviour
{
    // Start is called before the first frame update
    private static Dontdestroy tref;
    void Awake()
    {
        //DontDestroyOnLoad(gameObject);
        if (tref == null)
        {
            tref = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
        /* if (gameObject.activeSelf == false)
         {
             //gameObject.SetActive(false);
             //Debug.Log("destroyed");

             if (FindObjectsOfType(GetType()).Length > 1)
             {
                 Destroy(gameObject);
             }
         }*/
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
