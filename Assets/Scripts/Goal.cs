using UnityEngine;
using System.Collections;
public class Goal : MonoBehaviour
{
    public int player;
    public ScoreManager scoreManager;
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Puck"))
        {
            if (player == 1)
            {
                scoreManager.addGreenScore();
            }
            else
            {
                scoreManager.addBlueScore();
            }
            StartCoroutine(scoreManager.reset());
        }
    }
}
