﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HPSystem : MonoBehaviour
{
	[SerializeField] private int health = 3;
	[SerializeField] private int maxHealth = 3;


	[SerializeField] private bool haveToDrop;
	[SerializeField] private GameObject objectToDrop1;
	[SerializeField] private GameObject objectToDrop2;
	[SerializeField] private int chanceToDrop;

	private void Start()
	{
		maxHealth = health;
	}

   // private void OnCollisionEnter2D(Collision2D collision)
   // {
   //     if (collision.gameObject.CompareTag("Objetivo"))
   //     {
			//Destroy(this.gameObject);
   //     }
   // }

    private void OnTriggerEnter2D(Collider2D collision)
    {
		if (collision.gameObject.CompareTag("Objetivo"))
		{
			Destroy(this.gameObject);
		}
	}

    public void PlusHealth(int amount)
	{
		if (health + amount > maxHealth)
		{
			health = maxHealth;
		}
	}

	public void TakeHealth(int amount)
    {
		health -= amount;

		if (health <= 0)
		{
			Destroy(gameObject);
		}
	}

	public void ModifyHealth(int amount)
	{
		if (health + amount > maxHealth)
		{
			amount = maxHealth - health;
		}

		health += amount;

		//DEAD
		if (health <= 0)
		{
			DropItem();



			Destroy(gameObject);
		}
	}
	public void DropItem()
    {

        if (haveToDrop)
        {
			//int indice = Random.Range(0, objectToDrop1.Length);

			int rnd = Random.Range(0, 100);
            if (rnd <= chanceToDrop)
            {
				Instantiate(objectToDrop1, transform.position, Quaternion.identity);
            }
            if (rnd <= chanceToDrop)
            {
				Instantiate(objectToDrop2, transform.position, Quaternion.identity);
            }
        }
    }

}
