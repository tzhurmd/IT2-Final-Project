using UnityEngine;

public class Teleport : MonoBehaviour
{
    public Rigidbody2D rb;
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Portal"))
        {
            transform.position = new Vector2(0, 0);
        }
        if (other.CompareTag("Portal1"))
        {
            transform.position = new Vector2(-15, 0);
        }
        if (other.CompareTag("Portal2"))
        {
            transform.position = new Vector2(15, 0);
        }
        rb.linearVelocity = Vector2.zero;
    }
}
