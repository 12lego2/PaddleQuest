using UnityEngine;

public class PlayerPaddle : Paddle
{
    private Vector2 _direction;

    // Called every single frame for input/logic
    // Paddle movement left and right
    private void Update()
    {
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            _direction = Vector2.left;
        }
        else if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            _direction = Vector2.right;
        }
        else
        {
            _direction = Vector2.zero;
        }
    }

    // Called at a fixed time interval
    // Paddle physics
    private void FixedUpdate()
    {
        // If player paddle is moving
        if (_direction.sqrMagnitude != 0)
        {
            _rigidbody.AddForce(_direction * this.speed);
        }
    }
}
