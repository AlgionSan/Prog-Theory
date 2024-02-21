using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Player_Ship : Spaceship_Base
{
    [SerializeField] private int playerHealth;
    [SerializeField] private float playerSpeed;

    private void Start()
    {
        playerHealth = base.shipHealth;
        playerSpeed = base.shipSpeed - 5;
        Debug.Log("Player Health: " +  playerHealth);
    }

    // had move ship on fixed cause what if im calculating physics since its movement? or should stick with update?
    private void Update()
    {
        MoveShip();
    }

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






}
