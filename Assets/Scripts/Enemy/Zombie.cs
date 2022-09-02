using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zombie : MonoBehaviour
{


    [SerializeField] protected ZombieData zombieData;


    protected virtual void Move()
    {
        transform.Translate(Vector3.forward*zombieData.speed*Time.deltaTime);
    }

    public void Attack()
    {

        RaycastHit hit;

        if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit, zombieData.rangeAttack))
        {
            if (hit.transform.CompareTag("Player"))
            {
                Debug.Log("ATACAR AL JUGADOR");
            }
            
        }
    }


    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Move();
        Attack();
    }
    
    public void DrawRaycast()
    {
        Gizmos.color = Color.blue;
        Vector3 directionRay = transform.TransformDirection(Vector3.forward) * zombieData.rangeAttack;
        
        Gizmos.DrawRay(transform.position+Vector3.up,directionRay);
    }

    private void OnDrawGizmos()
    {
        DrawRaycast();
        
    }
}

