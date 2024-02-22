using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Asteroid_1 : Enemy_Base
{
    private Player_Ship playerShip;
    private float speed;
    private int playerHealth;
      
    // Start is called before the first frame update
    void Start()
    {
        speed = base.enemySpeed - 5f;

    }

    // Update is called once per frame
    void Update()
    {
        MoveEnemy();
    }

    protected override void MoveEnemy()
    {
        // Move the enemy downward along the z-axis
        transform.Translate(Vector3.back * speed * Time.deltaTime);

        // Check if the enemy has moved out of the screen
        if (transform.position.z < -5f)
        {
            // Destroy the enemy if it's out of the screen to prevent clutter
            Destroy(gameObject);
            Debug.Log("Enemy_Asteroid Destroyed Out Of Bounds");
        }
    }


    protected override void DealDamage()
    {
        //dead damage
    }


}
