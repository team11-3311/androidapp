using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class queen_scene_manager : MonoBehaviour
{
    // Start is called before the first frame update
    public void on_click()
    {
        SceneManager.LoadScene(5);
    }
}
