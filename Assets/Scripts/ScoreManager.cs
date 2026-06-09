using UnityEngine;
using TMPro;
using System.Collections;
using UnityEngine.SceneManagement;
public class ScoreManager : MonoBehaviour
{
    public TextMeshProUGUI leftScoreText;
    public TextMeshProUGUI rightScoreText;
    public TextMeshProUGUI scoreGoal;
    public TextMeshProUGUI endGame;
    public Transform ball;
    public Transform greenPlayer;
    public Transform bluePlayer;
    public GameObject button;
    public int greenScore = 0;
    public int blueScore = 0;
    public Rigidbody2D rb;
    public void addGreenScore()
    {
        greenScore++;
        leftScoreText.text = "Green: " + greenScore;
        scoreGoal.text = "Green Goal!";
    }
    public void addBlueScore()
    {
        blueScore++;
        rightScoreText.text = "Blue: " + blueScore;
        scoreGoal.text = "Blue Goal!";
    }
    public IEnumerator reset()
    {
        yield return new WaitForSeconds(1);
        ball.position = new Vector2(0, 0);
        greenPlayer.position = new Vector2(-20, 0);
        bluePlayer.position = new Vector2(20, 0);
        scoreGoal.text = "";
        rb.linearVelocity = Vector2.zero;
        if (blueScore == 3)
        {
            endGame.text = "Blue Wins!";
            button.SetActive(true);
        }
        if (greenScore == 3)
        {
            endGame.text = "Green Wins!";
            button.SetActive(true);
        }
    }
    public void resetGame()
    {
        SceneManager.LoadScene(0);
    }
}
