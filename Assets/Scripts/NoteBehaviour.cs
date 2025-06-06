using UnityEngine;

public class NoteBehaviour : MonoBehaviour
{
    public string noteName;
    public float fallSpeed = 5f;

    void Update()
    {
        transform.Translate(Vector3.down * fallSpeed * Time.deltaTime);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        // Only destroy when hitting the bottom boundary
        if (other.name == "BottomBoundary")
        {
            Destroy(gameObject);
        }
    }
}