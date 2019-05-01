using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEditor;
using UnityEngine.SceneManagement;

public class Dooropen : MonoBehaviour
{
    // Start is called before the first frame update

    private Animator anims;
    public string ans;
    public GameObject dro;

    void Start()
    {
        dro = GameObject.FindGameObjectWithTag("WAY");
        anims = dro.GetComponent<Animator>();
        var input = gameObject.GetComponent<InputField>();
        var answer = new InputField.SubmitEvent();
        answer.AddListener(SubmitName);
        input.onEndEdit = answer;

        //Debug.Log("open door");
            //anims.SetTrigger("sesame");

    }

    private void SubmitName(string arg0)
    {
        //throw new NotImplementedException();
        Debug.Log(arg0);
        arg0 = arg0.ToLower();
        if (arg0.Equals(ans))
        {
            
            Debug.Log("right answer");
            anims.SetTrigger("sesame");

            if (EditorUtility.DisplayDialog("Success!!!", "You have solved the mystery", "Proceed"))
            {
                
                Debug.Log("done");
                SceneManager.LoadScene(0);
                
            }
            
        }
  

    }

    // Update is called once per frame
    void Update()
    {
       
    }
}
