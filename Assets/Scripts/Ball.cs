using System.Collections;
using UnityEngine;

public class Ball : MonoBehaviour
{
    [SerializeField] private float speed = 8f;
    private Rigidbody2D _rb;
    private Vector2 _direction;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
        LaunchBall();
    }
    
    void LaunchBall()
    {
        // Direção inicial aleatória
        float x = Random.value < 0.5f ? -1f : 1f;
        float y = Random.Range(-0.5f, 0.5f);

        _direction = new Vector2(x, y);

        _rb.linearVelocity = _direction * speed;
    }

    public void ResetBall()
    {
        _rb.linearVelocity = Vector2.zero;
        transform.position = Vector2.zero;
        
        StartCoroutine(PlayBall());
    }

    IEnumerator PlayBall()
    {
        yield return new WaitForSeconds(2f);
        LaunchBall();
    }
    
    // void OnCollisionEnter2D(Collision2D collision)
    // {
    //     Vector2 normal = collision.contacts[0].normal;
    //     Vector2 newDir = Vector2.Reflect(_direction, normal);

    //     if (collision.gameObject.CompareTag("Wall"))
    //     {
    //         if (Mathf.Abs(newDir.y) < 0.2f)
    //         {
    //             newDir.y = 0.2f * Mathf.Sign(newDir.y == 0 ? 1 : newDir.y);
    //         }
    //     }

    //     _direction = newDir.normalized;
    // }
}
