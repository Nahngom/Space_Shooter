using UnityEngine;

public class BackgroundScrolling : MonoBehaviour
{
    public float scrollSpeed = 0.5f;
    private Vector2 startPosition;
    private float textureHeight;

    void Start()
    {
        startPosition = transform.position;
        textureHeight = GetComponent<SpriteRenderer>().bounds.size.y;
    }

    void Update()
    {
        transform.position += Vector3.down * scrollSpeed * Time.deltaTime;

        if (transform.position.y <= startPosition.y - textureHeight)
        {
            transform.position = new Vector2(startPosition.x, startPosition.y);
        }
    }

}
