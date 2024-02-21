using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// this class uses the abstraction principle - abstracting out only the necessary details for any object of Spaceship.. 
// making this is the base class for the spaceship...
// wait if i have a base class for spaceship while i mainly thought of its usage for player..
// it can be use as a base for enemy ship too as long as it is a spaceship.. that means i can override the movement of it or anything... huh...
public abstract class Spaceship_Base : MonoBehaviour
{
    // Below are attributes of a space ship

    // Variables:
    // Ship Health
    // Ship Speed
    private int m_BaseShipHealth = 5; // this is a private backing field for variabe protection (encapsulation)

    // using encapsulation, we can get the baseShipHealth outside of class but can only set it inside of the Spaceship_Base Class
    public int baseShipHealth 
    {
        get { return m_BaseShipHealth; } // getter method returns variable m_baseShipHealth
        private set 
        {
            /* 
  
            This setter condition will allow player to set the health of the baseShip but it must be a value greater than 0 to prevent errors.

            if (value < 0.0f)
            {
                Debug.LogError("You can't set a negative Health!");
            }
            else
            {
                m_BaseShipHealth = value;
            }
            
            */


        } // setting the setter method(?) into private allows to set the value only within the class and not outside

    }

    //protected int baseShipHealth = 5;
    protected float shipSpeed = 10;

    // Methods:

    // method spaceship_movement - ship can move
    // abstract method means child class needs to override the method
    protected abstract void MoveShip();


    // method spaceship_shoot - ship can shoot
    // virtual method means child class does not need to override shoot projectile but they can
    protected virtual void ShootProjectile()
    { 
        //shoot projectile here or something
    
    }



}
