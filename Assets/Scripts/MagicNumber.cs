using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental;
using UnityEngine;
using UnityEngine.UI;

public class MagicNumber : MonoBehaviour
{
    public Text answer;
    public Text count;
    public Text endGame;
    public int min = 1;
    public SceneLoader sceneLoader;
    public int max = 1000;
    private int i = 0;
    public bool isPlay = true;
    private int guess;

    private void Awake()
    {
        DontDestroyOnLoad(gameObject);
    }

    void Start()
    {
        answer.text = "Загадайте число от " + min +" до " + max;
        
        endGame.text = "";

    }

    // Update is called once per frame
    void Update()
    {
        if (!isPlay)
        {
            return;
        }
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            min = guess;
            UpdateGuess();
        }

        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            max = guess;
            UpdateGuess();
        }
        if (Input.GetKeyDown(KeyCode.KeypadEnter) || Input.GetKeyDown(KeyCode.Return))
        {
            GameOver();
        }

        if (Input.GetKeyDown((KeyCode.Space)))
        {
            restartGame();
            Start();
        }
    }

    private void UpdateGuess()
    {
        guess = (min + max) / 2;
        answer.text = "Это число вы загадывали? " + guess + "?";
        i++;
    }

    private void restartGame()
    {
        min = 1;
        max = 1000;
        i = 0;
    }

    private void GameOver()
    {
        isPlay = false;
        sceneLoader.ChangeScene(2);
    }

    public void MoreButtonClick()
    {
        min = guess;
        UpdateGuess();
    }
    public void LessButtonClick()
    {
        max = guess;
        UpdateGuess();
    }

    public void ConfirmButton()
    {
        GameOver();
        //sceneLoader.ChangeScene(2);
    }
}
