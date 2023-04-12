using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainManager : MonoBehaviour
{
    public static MainManager Instance; 
    public int nextLevel = 1;
    public CanvasGroup gameOverCanvas;
    public float fadeDuration = 1.5f;
    public float gameOverCanvasDuration = 1.5f;
    private float timer;

    private void Awake()
    {
        if (Instance != null)
        {
            Destroy(gameObject);
            return;
        }

        Instance = this;
        DontDestroyOnLoad(gameObject);
    }

    public void LoadNextLevel(){
        string sceneToLoad = "Level" + nextLevel.ToString();
        SceneManager.LoadScene(sceneToLoad);
        nextLevel++;
    }

    public void LevelComplete(){
        if(nextLevel < 4){
            SceneManager.LoadScene("EndOfTheLevel");
        }else{
            StartCoroutine(GameOver());
        }
    }

    IEnumerator GameOver(){
        gameOverCanvas.gameObject.SetActive(true);
        timer = 0;

        while(timer < fadeDuration){
            gameOverCanvas.alpha = Mathf.Lerp(0,1,timer / fadeDuration);
            timer += Time.deltaTime;
        }
        yield return new WaitForSeconds(gameOverCanvasDuration);
        nextLevel = 1;
        SceneManager.LoadScene("StartMenu");
        gameOverCanvas.gameObject.SetActive(false);
    }
}