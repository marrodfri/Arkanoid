using UnityEngine;

public class ball : MonoBehaviour
{
    public float speed = 2.0f;

    private Rigidbody2D rigidbody2D;
    
    void Start()
    {
        rigidbody2D = GetComponent<Rigidbody2D>();
        rigidbody2D.velocity = Vector2.up * speed;
    }

    float hitFactor (Vector2 ballPosition, Vector2 racketPosition,
        float racketWidth)
    {
        return (ballPosition.x - racketPosition.x) / racketWidth;
    }

    private void OnCollisionEnter2D(Collision2D col)
    {
        if(col.gameObject.name == "racket")
        {
            float x = hitFactor(transform.position, col.transform.position, col.collider.bounds.size.x);

            Vector2 direction = new Vector2(x, 1).normalized;
            
            rigidbody2D.velocity = direction * (speed * 1.2f);
        }  
    }

}