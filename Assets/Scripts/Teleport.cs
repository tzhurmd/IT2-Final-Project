using UnityEngine;

public class Teleport : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Portal"))
        {
            transform.position = new Vector2(0, 0);
        }
    }
}
