using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class key_info_script : MonoBehaviour
{

  
    public int has_key;
    private static key_info_script instanceRef;
    // Start is called before the first frame update
    void Start()
    {

        if (instanceRef == null)
        {
            instanceRef = this;
            DontDestroyOnLoad(gameObject);
        }

        else
        {
            DestroyImmediate(gameObject);
        }
        
        
        
    }

    public void add_key()
    {
        has_key = 1;
    }





}
