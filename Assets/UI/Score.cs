using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public int CurrentScore;
    public TMPro.TextMeshProUGUI ScoreText;

    void Start()
    {
        ScoreText.text = "Score: " + CurrentScore;
    }

    void Update()
    {
        ScoreText.text = "Score: " + CurrentScore;
    }
}