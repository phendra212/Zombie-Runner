using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Load_Scene_Back : MonoBehaviour
{
    public string sceneName;
    public Button loadSceneBtn;

     void Start()
    {
        loadSceneBtn.onClick.AddListener(ChangeScene);   
    }

    void ChangeScene()
    {
        SceneManager.LoadScene(sceneName);
    }
}
