using System.Collections;
using System.Collections.Generic;
using UnityEngine;


// this is the base class for the player ship...
// wait if i have a base class for spaceship while i mainly thought of its usage for player..
// it can be use as a base for enemy ship too as long as it is a spaceship.. that means i can override the movement of it or anything... huh...
public abstract class Spaceship_Base : MonoBehaviour
{
    // Below are attributes of a space ship

    // Variables:
    // Ship Health
    // Ship Speed
    protected int shipHealth = 5;
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
