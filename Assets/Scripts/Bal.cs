using UnityEngine;

public class Bal : MonoBehaviour
{
    public float speed = 6f;

    public Rigidbody2D rb;

    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        LaunchBall();
    }

    void LaunchBall()
    {
        rb.linearVelocity = Vector2.zero;

        Vector2 startDir = new Vector2( Random.Range(-0.7f, 0.7f), 1f);
        rb.linearVelocity = startDir * speed;
    }

    void Update()
    {
        if (gameObject.transform.position.y <= -5.0f)
        {
            Debug.Log("Game Over");
        }
    }
}