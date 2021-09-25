using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UiScore : MonoBehaviour
{

    public TextMeshProUGUI highScore;
    public TextMeshProUGUI currentScore;

    private void Update()
    {
        highScore.text = ScoreManager.Instance.HighScore.ToString();
        currentScore.text = ScoreManager.Instance.CurrentScore.ToString();
    }

    public void Show()
    {
        gameObject.SetActive(true);
    }


    public void Hide()
    {
        gameObject.SetActive(false);
    }
}
