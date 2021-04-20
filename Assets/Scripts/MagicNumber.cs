using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental;
using UnityEngine;
using UnityEngine.UI;

public class MagicNumber : MonoBehaviour
{
    #region Variables
  
    public Text answer;
    public Text result;
    public int min = 1;
    public SceneLoader sceneLoader;
    public int max = 1000;
    public int count = 0;
    public bool isPlay = true;
    public int guess;

    #endregion

    #region Methods

    private void Awake()
    {
        guess = max;
        DontDestroyOnLoad(gameObject);
    }

    private void Start()
    {
        answer.text = "Загадайте число от " + min +" до " + max;
    }

    private void UpdateGuess()
    {
        guess = (min + max) / 2;
        answer.text = "Это число вы загадывали? " + guess + "?";
        count++;
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
        result.text = $"Ваш загаданный номер: {guess}";
        GameOver();
    }

    #endregion
}
