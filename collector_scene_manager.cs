using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class collector_scene_manager : MonoBehaviour
{
    public void on_click()
    {
        SceneManager.LoadScene(12);
    }
}
