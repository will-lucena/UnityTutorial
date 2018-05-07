using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed;
    public float damage;

    // Use this for initialization
    void Start ()
    {
        GetComponent<Rigidbody2D>().velocity = Vector2.right * speed;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Turret"))
        {
            Destroy(gameObject);
        }

        if (collision.gameObject.CompareTag("Player"))
        {
            collision.GetComponent<Player>().takeDamage(damage);
            Destroy(gameObject);
        }
    }

}
