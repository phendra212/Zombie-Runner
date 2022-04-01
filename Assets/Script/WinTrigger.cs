using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinTrigger : MonoBehaviour
{
    [SerializeField] string nextLevelName;

     private void OnTriggerEnter(Collider col)
    {
     if(col.CompareTag("Player"))
        {
            SceneManager.LoadScene(nextLevelName);
        }
    }
}
