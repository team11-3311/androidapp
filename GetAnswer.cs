using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEditor;
using UnityEngine.SceneManagement;

public class GetAnswer : MonoBehaviour
{
    // Start is called before the first frame update]
    public GameObject rad;
    
    void Start()
    { var input = gameObject.GetComponent<InputField>();
        var answer = new InputField.SubmitEvent();
        
        answer.AddListener(SubmitName);
        input.onEndEdit = answer;
        //myText.onEndEdit.AddListener(SubmitName);
        rad = GameObject.FindGameObjectWithTag("BOX");
    }

    private void SubmitName(string arg0)
    {
        //throw new NotImplementedException();
        Debug.Log(arg0);
        if(arg0.Equals("shoe"))
        {
            Debug.Log("right answer");
            rad.SetActive(false);
            if (EditorUtility.DisplayDialog("Success!!!", "You earned a token", "Proceed"))
            {
                SceneManager.LoadScene(3);
            }
        }
      
    }

    // Update is called once per frame
    void Update()
    {

    }
}
