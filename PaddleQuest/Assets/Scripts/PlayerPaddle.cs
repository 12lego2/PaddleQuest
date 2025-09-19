using System.Timers;
using UnityEngine;

public class PlayerPaddle : Paddle
{
    private Vector2 _direction;

    //variables for Player and Mouse position respectively
    private Vector2 _playerPosition;
    private Vector2 m_position;

    public Animator pAnimator;
    float hMove = 0f;
    float vMove = 0f;
    // Called every single frame for input/logic
    // Paddle movement left and right [OLD]


    private void Update()
    {
        hMove = Input.GetAxisRaw("Horizontal") * speed;
        pAnimator.SetFloat("hSpeed", hMove);
        vMove = Input.GetAxisRaw("Vertical") * speed;
        pAnimator.SetFloat("vSpeed", vMove);
        _direction.x = hMove; 
        _direction.y = vMove;
        _direction.Normalize();
        _direction *= speed;

        if (Input.GetMouseButton(1))
        {
            //https://discussions.unity.com/t/make-object-follow-mouse-2d-game/520226/9

            m_position = Input.mousePosition;
           
        }


        //old movement code
        /*   if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
           {
               _direction = Vector2.left;
               //Put in the following but for hSpeed and vSpeed for l/r/u/d movement
               //pAnimator.SetFloat("USpeed", 0);
               
               pAnimator.SetTrigger("Bounce")
           }
           else if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
           {
               _direction = Vector2.right;
           }
           else if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow))
           {
               _direction = Vector2.up;
           }
           else if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow))
           {
               _direction = Vector2.down;
           }
           else
           {
               _direction = Vector2.zero;
        }
        
       */ 
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("Pong"))
        {
            Debug.Log("Player hit a Pong!");
            pAnimator.SetTrigger("Bounce");
           // pAnimator.ResetTrigger("Bounce");
        }
    }

    // Called at a fixed time interval
    // Paddle physics
    private void FixedUpdate()
    {
        _rigidbody.linearVelocity = _direction;

        // If player paddle is moving
     /*   if (_direction.sqrMagnitude != 0)
        {
            _rigidbody.AddForce(_direction * this.speed);
           
        }
     */
    }
}
