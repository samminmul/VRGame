using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIManager : MonoBehaviour
{
    public TextMeshProUGUI scoreText;

    private float currentScore = 0f;
    // Start is called before the first frame update
    void Start()
    {
        SetScore(0);
    }

    public void SetScore(int score)
    {
        currentScore += score;
        scoreText.text = "Score: " + currentScore;
    }
}
