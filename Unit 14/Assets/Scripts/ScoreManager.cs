using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    public int score;
    public TextMeshProUGUI scoreText;

    public void GetPoints(string name)
    {
        int points = 0;
        switch (name)
        {
            case "Mothership(Clone)":
                points = 50;
                break;
            case "UFO(Clone)":
                points = 100;
                break;
            case "Scout(Clone)":
                points = 150;
                break;
        }

        IncreaseScore(points);
    }

    public void LosePoints(string name)
    {
        int points = 0;
        switch (name)
        {
            case "Mothership(Clone)":
                points = 50;
                break;
            case "UFO(Clone)":
                points = 100;
                break;
            case "Scout(Clone)":
                points = 150;
                break;
        }

        DecreaseScore(points);
    }

    public void IncreaseScore(int amount)
    {
        score += amount;
        UpdateScoreText();
    }

    public void DecreaseScore(int amount)
    {
        score -= amount;
        UpdateScoreText();
    }

    public void UpdateScoreText()
    {
        scoreText.text = "Score: " + score;
    }
}
