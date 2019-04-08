using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GetAnswer : MonoBehaviour
{
    //var myText = gameObject.GetComponent<InputField>();
    // Start is called before the first frame update
    void Start()
    {
        var input = gameObject.GetComponent<InputField>();
        var se = new InputField.SubmitEvent();
        se.AddListener(SubmitName);
        input.onEndEdit = se;
        //myText.onEndEdit.AddListener(SubmitName);
    }

    private void SubmitName(string arg0)
    {
        //throw new NotImplementedException();
        Debug.Log(arg0);
       /* if(arg0 != "shoe")
        {

        }*/
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
