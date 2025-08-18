using UnityEngine;
using UnityEngine.EventSystems;

public class DamageTrigger : MonoBehaviour
{
    public EventTrigger.TriggerEvent damageTrigger;

    /*
     * Called when an object collides with something
     * Adjust health upon collision of the arrow
     */
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Ball ball = collision.gameObject.GetComponent<Ball>();

        if (ball != null)
        {
            BaseEventData eventData = new BaseEventData(EventSystem.current);
            this.damageTrigger.Invoke(eventData);
        }
    }
}