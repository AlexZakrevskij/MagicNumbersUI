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
        turnCount.text = $"Trying count: {magicNumber.count}";
        rememberNumber.text = $"Your number: {magicNumber.answer}";
    }

    #endregion
}
