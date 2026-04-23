using UnityEngine;

public class PointManager : MonoBehaviour
{
    
    [SerializeField] private GameManager gameManager;


    void OnTriggerEnter2D(Collider2D collision)
    {
        Rigidbody2D rb;
        if (collision.TryGetComponent<Rigidbody2D>(out rb))
        {
            if (rb.linearVelocityX > 0)
            {
                gameManager.PlayerPoint();
                Debug.Log("Player Score");
            } else
            {
                gameManager.IaScore();
                Debug.Log("IA Score");
            }
        }

        collision.GetComponent<Ball>().ResetBall();
    }
}
