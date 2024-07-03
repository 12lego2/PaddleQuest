using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public float speed = 200.0f;

    private Rigidbody2D _rigidbody;
    private Vector3 originalPos;

    public void AddForce(Vector2 force)
    {
        _rigidbody.AddForce(force);
    }

    public void ResetPosition()
    {
        //_rigidbody.position = Vector3.up;
        _rigidbody.velocity = Vector3.up;
        transform.position = originalPos;

        AddStartForce();
    }

    private void Awake()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
    }

    // Set position at game start
    private void Start()
    {
        originalPos = transform.position;

        ResetPosition();
    }

    // Random direction at start
    private void AddStartForce()
    {
        // Angle                         down   up
        float x = Random.value < 0.5f ? -1.0f : 1.0f;

        // Vertical                                   min   max                   min   max
        float y = Random.value < 0.5f ? Random.Range(-1.0f, -0.5f) : Random.Range(-0.5f, -1.0f);


        Vector2 direction = new Vector2(x, y);
        // Increase speed
        _rigidbody.AddForce(direction * this.speed);
    }
}
