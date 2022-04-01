using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu_Manager : MonoBehaviour
{
    public GameObject Panel;
    public GameObject CreditPanel;
    public GameObject howtopanel;

    // Start is called before the first frame update
    void Start()
    {
        Panel.SetActive(true);
        CreditPanel.SetActive(false);
        howtopanel.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

   public void playbuttonClicked()
    {
        Application.LoadLevel("Level 1");
    }
    public void aboutbuttonClicked()
    {
        Panel.SetActive(false);
        CreditPanel.SetActive(true);
        howtopanel.SetActive(false);
    }
    public void howtoplayButtonClicked()
    {
        Panel.SetActive(false);
        CreditPanel.SetActive(false);
        howtopanel.SetActive(true);
    }
   public  void exit_Clicked()
    {
        Application.Quit();
    }
    public void backbuttonClicked()
    {
        Panel.SetActive(true);
        CreditPanel.SetActive(false);
        howtopanel.SetActive(false);
    }
    public void backbutton2Clicked()
    {
        Panel.SetActive(true);
        CreditPanel.SetActive(false);
        howtopanel.SetActive(false);
    }
}
