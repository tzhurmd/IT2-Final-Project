using UnityEngine;
using System.Collections;
public class Goal : MonoBehaviour
{
    public int player;
    public ScoreManager scoreManager;
    public Rigidbody2D rb;
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Puck"))
        {
            if (player == 1)
            {
                rb.linearVelocity = Vector2.zero;
                scoreManager.addBlueScore();
            }
            else
            {
                rb.linearVelocity = Vector2.zero;
                scoreManager.addGreenScore();
            }
            StartCoroutine(scoreManager.reset());
        }
    }
}
