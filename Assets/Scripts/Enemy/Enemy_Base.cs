using System.Collections;
using System.Collections.Generic;
using UnityEngine;


// this script is the base class for enemy
public abstract class Enemy_Base : MonoBehaviour
{
    // this class it contains the characteristics and attribtues of enemy

    // variables of a base enemy
    // enemyHealth, enemySpeed, enemyDamage

    protected int enemyHealth;
    protected float enemySpeed = 10;
    [SerializeField] private EnemyType enemyType;
    private int enemyDamage = 2;



    public int EnemyDamage { get => enemyDamage; }
    public EnemyType EnemyType { get => enemyType;}

    // methods of what a base enemy can do
    // enemy can enemy can move and can deal damage

    protected abstract void MoveEnemy();

    protected abstract void DealDamage();



}

public enum EnemyType
{
    Asteroid,
    Ship



}