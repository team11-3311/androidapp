using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class room1_safe_manager : MonoBehaviour
{
    public InputField answer;
    public Text ftext;


    // Start is called before the first frame update
    public void on_back_click()
    {
        SceneManager.LoadScene(5);
    }

    public void on_try_click()
    {
        if (string.Compare(answer.text, "1776") == 0)
        {
            SceneManager.LoadScene(10);
        }
        else
        {
            ftext.text = "Incorrect. Try Again!";
        }
    }

}
