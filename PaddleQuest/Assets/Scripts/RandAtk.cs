using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandAtk : MonoBehaviour
{
    public float life = 3;

        void Awake()
    {
        Destroy(gameObject, life);
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        //need to make it so that it checks if it hit Healthbar or 
        //destroys self
        Destroy(gameObject);
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
