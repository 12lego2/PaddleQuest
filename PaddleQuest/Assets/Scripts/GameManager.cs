using UnityEngine;

public class GameManager : MonoBehaviour
{
    //public Arrow arrow;
    public Ball ball;
    public int damage = 10;
    public int maxHealth = 100;
    /*public HealthBar healthBar;*/

    private int _playerHealth;
    private int _compHealth;

    void Start()
    {
        _playerHealth = maxHealth;
        _compHealth = maxHealth;
    }

    public void PlayerDamage()
    {
        _playerHealth -= damage;
        Debug.Log("Player " + _playerHealth);

        if(_playerHealth <= 0 )
        {
            Debug.Log("You died");
        }
        else
        {
            //this.arrow.ResetPosition();
            this.ball.ResetPosition();
        }
    }

    public void CompDamage()
    {
        _compHealth -= damage;
        Debug.Log("Computer " + _compHealth);

        if (_compHealth <= 0)
        {
            Debug.Log("You win");
        }
        else
        {
            //this.arrow.ResetPosition();
            this.ball.ResetPosition();
        }
    }
}
