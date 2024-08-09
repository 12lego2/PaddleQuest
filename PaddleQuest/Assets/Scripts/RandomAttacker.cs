using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class RandomAttacker : MonoBehaviour
{
    public Transform AttackSpawn;
    public GameObject attackPrefab;
    public float AttackSpeed = 10;
    public double AttackDelay = 1;
    //try below on Awake;
    
    void update()
    {
       
       // if(timer => AttackDelay)
       // {
       //     Timer = 0;
       //     var Attack = Instantiate(attackPrefab, AttackSpawn.position, AttackSpawn.rotation);
       //     Attack.GetComponent<RigidBody2D>().velocity = AttackSpawn.up * AttackSpeed;
       // }
      //  var Attack = Instantiate(attackPrefab, AttackSpawn.position, AttackSpawn.rotation);
       // Attack.GetComponent<RigidBody2D>().velocity = AttackSpawn.up * AttackSpeed;

    }
}
