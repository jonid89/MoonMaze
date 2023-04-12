using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
   public void PlayNextLevel()
    {
        MainManager.Instance.LoadNextLevel();
    }
    public void ExitGame()
    {
        Application.Quit();
    }
}
