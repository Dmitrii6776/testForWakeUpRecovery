using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Scoreboard : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI scoreText;
    [SerializeField] private DataBase dataBase;

    private void Start()
    {
        scoreText.text = $"Max Score: {dataBase.MaxScore.ToString()}";
    }
}
