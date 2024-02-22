using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Player_Ship : Spaceship_Base
{
    
    [SerializeField] private int playerHealth;
    [SerializeField] private float playerSpeed;

    public int PlayerHealth { get => playerHealth;  }


    private void Start()
    {
        // Person student1 = new Person
        // student.setName("Adrian");
        // printf(student.getName);


        // accessing the ship health attribute of the base ship and setting it to player health is Inheritance
        playerHealth = baseShipHealth;
        playerSpeed = base.shipSpeed - 5;
        UI_Main_Scene.instance.UpdatePlayerHealth(playerHealth);


    }

    // had move ship on fixed cause what if im calculating physics since its movement? or should stick with update?
    private void Update()
    {
        //if is game active true then move ship
        if (UI_Main_Scene.instance.isGameActive)
        {
            MoveShip();

        }
        


    }


    // this is polymorphism, overriding the moveship method from base method to allow player input to move the ship
    protected override void MoveShip()
    {
        //move ship here through player input

        // Get input from horizontal and vertical axes
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        // Calculate movement direction
        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);

        // Normalize the movement vector to ensure constant speed in all directions
        movement = movement * playerSpeed * Time.deltaTime;



        // Move the spaceship
        transform.Translate(movement);


    }



    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Enemy"))
        {
            Enemy_Base enemy = other.GetComponent<Enemy_Base>();
            int enemyDamage = 0;
            if(enemy != null) 
            {
                switch (enemy.EnemyType)
                {
                    case EnemyType.Asteroid:
                        Enemy_Asteroid_1 newEnemy = enemy as Enemy_Asteroid_1;
                        enemyDamage = newEnemy.EnemyDamage;
                        break;
                    case EnemyType.Ship:
                        break;
                    default:
                        break;
                }
                TakeDamage(enemyDamage);
                Debug.Log("Enemy Deals: " + enemyDamage);
                Debug.Log("Current Health: " + playerHealth);
            }
            
        
        }

    }

    void TakeDamage(int damage) 
    {
        playerHealth -= damage;
        UI_Main_Scene.instance.UpdatePlayerHealth(playerHealth);

        if (playerHealth < 0)
        {
            UI_Main_Scene.instance.GameOver();
           
        
        }

    }


}
