using UnityEngine;

public class AtkArea : MonoBehaviour
{
    public Vector3 mousePos;
    private Camera mainCam;


    //use element0 on polygon for center point
    PolygonCollider2D polygons;
    
    private void Start()
    {
    //latch on to what is considered main cam; specifically player's cam in the case of cutscene cameras
        mainCam = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<Camera>();
    }

    private void Update()
    {
        mousePos = mainCam.ScreenToWorldPoint(Input.mousePosition);
    }


    private void OnTriggerEnter2D(Collider2D collider)
    {if(collider.gameObject.CompareTag("Pong"))
        {
            collider.gameObject.GetComponent<Ball>().WasHit(mousePos);
            /*Rigidbody rb = collider.gameObject.GetComponent<Rigidbody>();

            if (rb != null)
            {
                currentVector = rb.linearVelocity;
                //newVector = 
            }
            else { Debug.Log("AtkArea Collider could not get RigidBody of Pong"); }
            */
        }    
        

       
    }



}
