using UnityEngine;

public class BulletMovement : MonoBehaviour
{
    public float bullet_max_speed = 10.0f;

    void Update()
    {
        transform.Translate(Vector2.up * bullet_max_speed * Time.deltaTime);
    }

    private int HitPoints = 1;

    int return_HitPoints()
    {
        HitPoints--;
        return HitPoints;
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("Triggerred");
        if (other.CompareTag("SpaceShip"))
        {
            Debug.Log("ignored by buller");
            return;
        }

        if (return_HitPoints() <= 0)
        {
            Die();

        }
    }
    void Die()
    {
        Destroy(gameObject);
    }
}
