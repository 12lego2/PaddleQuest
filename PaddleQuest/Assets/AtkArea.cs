using UnityEngine;

public class AtkArea : MonoBehaviour
{
    public Vector3 currentVector;
    public Vector3 newVector;

    //use element0 on polygon for center point
    PolygonCollider2D polygons;
    
    private void Start()
    {
      
    }
    


    private void OnTriggerEnter2D(Collider2D collider)
    {if(collider.gameObject.CompareTag("Pong"))
        {
            Rigidbody rb = collider.gameObject.GetComponent<Rigidbody>();

            if (rb != null)
            {
                currentVector = rb.linearVelocity;
                //newVector = 
            }
            else { Debug.Log("AtkArea Collider could not get RigidBody of Pong"); }

        }    
        

       
    }



}
