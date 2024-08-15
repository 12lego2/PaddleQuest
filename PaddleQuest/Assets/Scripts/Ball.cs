using UnityEngine;

public class Ball : MonoBehaviour
{

    public float MaxSpeed = 120f;
    public float speed = 80.0f;
    public GameManager gmanager;
    public int whichSprite;
    public Sprite arrow;
    public Sprite ball;

    private Rigidbody2D _rigidbody;
    private Vector3 originalPos;

    public void AddForce(Vector2 force)
    {
        _rigidbody.AddForce(force);
    }

    // Respawn ball and randomize ball or arrow projectile
    public void ResetPosition()
    {
        //_rigidbody.position = Vector3.up;
        /*_rigidbody.velocity = Vector3.up;*/

        // Create a Vector3 with a random x position between -4 and 4
        float randomX = Random.Range(-4f, 4f);

        Vector3 randomPos = new Vector3(randomX, originalPos.y, originalPos.z);

        // Assign this random position to the object's transform
        transform.position = randomPos;

        /*transform.position = originalPos;*/

        AddStartForce();

        whichSprite = Random.Range(1, 10);
        if (whichSprite % 2 == 0)
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = arrow;
        }
        else
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = ball;
        }
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

        //code to calc the % is going to be Max HP - Current HP divided by 100

        float finalspeed = Mathf.Lerp(speed, MaxSpeed, 1);
        _rigidbody.AddForce(direction * finalspeed);
    }

    private void Awake()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (whichSprite % 2 == 0) 
        {
            // If arrow hits the player paddle
            if (collision.gameObject.CompareTag("Paddle"))
            {
                ResetPosition();
            }
            else if(collision.gameObject.CompareTag("PlayerWall"))
            {
                gmanager.PlayerDamage();
            }
        }
    }

    // Set position at game start
    private void Start()
    {
        originalPos = transform.position;
        ResetPosition();
    }
}
