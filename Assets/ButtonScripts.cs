using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ButtonScripts : MonoBehaviour
{
    public void playAgainButton()
    {
        SceneManager.LoadScene("Game");
    }

    public void exitButton()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
