using UnityEngine;

public class BounceSurface : MonoBehaviour
{
    public float bounceStrength;

    /*
     * Called when an object collides with something
     * Increase velocity when paddle hits the arrow
     */
    /*private void OnCollisionEnter2D(Collision2D collision)
    {
        Arrow arrow = collision.gameObject.GetComponent<Arrow>();

        if(arrow != null )
        {
            Vector2 normal = collision.GetContact(0).normal;
            arrow.AddForce(normal * this.bounceStrength);
        }
    }*/
}
