using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;


public class Scenes : MonoBehaviour
{
    public void ExitButton()
    {
        Application.Quit();
    }
    public void GameMenu()
    {
        SceneManager.LoadScene("GameMenu");
    }
    public void GameMenu2()
    {
        SceneManager.LoadScene("GameMenu2");
    }
    public void MainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
    public GameObject player;

    public GameObject panel;
    public void PanelAc()
    {
        panel.SetActive(true);
    }
    public void PanelKapat()
    {
        panel.SetActive(false);
    } 

    public void Kill()
    {
        player.GetComponent<CharacterControls>().LoadCheckPoint();
    }

}
