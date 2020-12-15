using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove : MonoBehaviour
{
    public float moveSpeed;

    public bool rightMovement;

    // Update is called once per frame
    void Update()
    {
        if(rightMovement)
        {
            transform.Translate(2 * Time.deltaTime * moveSpeed, 0, 0);
        }
        else
        {
            transform.Translate(-2 * Time.deltaTime * moveSpeed, 0, 0);
        }

    }

     void OnTriggerEnter2D(Collider2D turn)
    {
        if(turn.gameObject.CompareTag("Turn"))
        {
            if(rightMovement)
            {
                rightMovement = false;
            }
            else
            {
                rightMovement = true;
            }
        }
    }



}
