using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class start_prompt_manager : MonoBehaviour
{
    public void on_click()
    {
        SceneManager.LoadScene(5);
    }
}
