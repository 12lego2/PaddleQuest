using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public Ball ball;
    public int ballDamage = 10;

    public int maxHealth = 100;
    public Slider playerHealthSlider;
    public Slider compHealthSlider;

    private int _playerHealth;
    public float _compHealth;

    void Start()
    {
        _playerHealth = maxHealth;
        _compHealth = maxHealth;
    }

    void Update()
    {
        // Update slider if the health slider is not the same amount as player health
        if (playerHealthSlider.value != _playerHealth)
        {
            playerHealthSlider.value = _playerHealth;
        }

        // Update slider if the health slider is not the same amount as player health
        if (compHealthSlider.value != _compHealth)
        {
            compHealthSlider.value = _compHealth;
        }

        // Reload the scene if the player is dead
        if (_playerHealth <= 0 || _compHealth <= 0)
        {
            Application.LoadLevel(Application.loadedLevel);
        }
    }

    public void PlayerDamage()
    {
        _playerHealth -= ballDamage;
        Debug.Log("Player " + _playerHealth);

        if (_playerHealth <= 0)
        {
            Debug.Log("You died");

        }
        else
        {
            this.ball.ResetPosition();
        }
    }

    public void CompDamage()
    {
        // If an arrow, respawn without damage
        /*if (ball.whichSprite % 2 == 0)
        {
            this.ball.ResetPosition();
        }
        else
        {*/
            _compHealth -= ballDamage;
            Debug.Log("Computer " + _compHealth);

            if (_compHealth <= 0)
            {
                Debug.Log("You win");
            }
            else
            {
                this.ball.ResetPosition();
            }
        //}
    }
}
