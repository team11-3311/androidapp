using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;



public class load_scene : MonoBehaviour
{

    public InputField answer;
    public Text ftext;

    public void setGet()
    {

        if (string.Compare(answer.text, "answer") == 0)
        {
            SceneManager.LoadScene(6);
        }
        else
        {
            ftext.text = "Incorrect. Try Again!";
        }
    }

    public void go_back()
    {
        SceneManager.LoadScene(5);
    }

}
