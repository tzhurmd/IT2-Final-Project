using UnityEngine;
using TMPro;
using System.Collections;
public class ScoreManager : MonoBehaviour
{
    public TextMeshProUGUI leftScoreText;
    public TextMeshProUGUI rightScoreText;
    public TextMeshProUGUI scoreGoal;
    public Transform ball;
    public Transform greenPlayer;
    public Transform bluePlayer;
    public int greenScore = 0;
    public int blueScore = 0;
    public void addGreenScore()
    {
        greenScore++;
        leftScoreText.text = "Blue: " + greenScore;
        scoreGoal.text = "Blue Goal";
    }
    public void addBlueScore()
    {
        blueScore++;
        rightScoreText.text = "Green: " + blueScore;
        scoreGoal.text = "Green Goal";
    }
    public IEnumerator reset()
    {
        yield return new WaitForSeconds(1);
        ball.position = new Vector2(0, 0);
        greenPlayer.position = new Vector2(-20, 0);
        bluePlayer.position = new Vector2(20, 0);
        scoreGoal.text = "";
    }

}
