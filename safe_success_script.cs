using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class safe_success_script : MonoBehaviour
{

    GameObject key_info;
    key_info_script kis;

    // Start is called before the first frame update
    public void change_scene()
    {
        key_info = GameObject.FindGameObjectWithTag("key_info");
        kis = key_info.GetComponent<key_info_script>();
        kis.add_key();
        SceneManager.LoadScene(5);
    }
}
