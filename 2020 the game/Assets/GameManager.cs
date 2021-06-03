using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class GameManager : MonoBehaviour
{

    public Text m_ScoreText;

    public int increase = 1;
    private float score = 0f;

    public void ChangeToGame()
    {
        SceneManager.LoadScene("GamePlay");
    }

    public void GoBackToGUI()
    {
        SceneManager.LoadScene("GUI");
    }

    private void FixedUpdate()
    {
        score += increase;
        m_ScoreText.text = "SCORE: " + score.ToString();
    }
}
