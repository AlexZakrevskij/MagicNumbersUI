using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameOverView : MonoBehaviour
{
    #region Variables
    public Text rememberNumber;
    public Text turnCount;
    public MagicNumber magicNumber;
    #endregion

    #region livecycle
    private void Start()
    {
        MagicNumber magicNumber = FindObjectOfType<MagicNumber>();
        turnCount.text = $"Затрачено поппыток на угадывание: {magicNumber.count}";
        rememberNumber.text = $"Вы загадали: {magicNumber.guess}";
        Destroy(magicNumber);
    }
    #endregion
}
