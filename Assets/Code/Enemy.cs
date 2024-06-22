using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int damage = 10;
    public int health = 50;
    public int speed = 5;
    public GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        ChasePlayer();
    }

    public void TakeDamage(int damageAmount)
    {
        health -= damageAmount;
        if (health <= 0)
        {
            Die();
        }
    }

    void Die()
    {

        Destroy(gameObject);
    }
    void ChasePlayer(){
        transform.position = Vector3.MoveTowards(transform.position,player.transform.position,speed*Time.deltaTime);
    
    }

    private void OnCollisionEnter(Collision other) {
        if(other.transform.tag == "Player"){
            other.gameObject.GetComponent<HEALTH>().TakeDamage(10);
        }
    
    }
}


