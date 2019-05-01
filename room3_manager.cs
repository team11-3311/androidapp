using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class room3_manager : MonoBehaviour
{

    public InputField answer;
    public Text ftext;

    // Start is called before the first frame update
    public void on_back_click()
    {
        SceneManager.LoadScene(12);
    }

    // Update is called once per frame
    public void on_try_click()
    {
        if (string.Compare(answer.text, "answer") == 0)
        {
            SceneManager.LoadScene(14);
        }
        else
        {
            ftext.text = "Incorrect. Try Again!";
        }
    }
}
