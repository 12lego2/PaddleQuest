using UnityEngine;

public class Paddle : MonoBehaviour
{
    public float speed = 10.0f;

    protected Rigidbody2D _rigidbody;

    private void DisableOffScreen()
    {
        _rigidbody.isKinematic = true;
    }

    // Initialization
    private void Awake()
    {
        // Look in the object to find Rigidbody 2D component then assign to _rigidbody
        _rigidbody = GetComponent<Rigidbody2D>();
    }
}
