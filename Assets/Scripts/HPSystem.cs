using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HPSystem : MonoBehaviour
{
	[SerializeField] private int health = 3;
	[SerializeField] private int maxHealth = 3;


	[SerializeField] private bool haveToDrop;
	[SerializeField] private GameObject objectToDrop;
	[SerializeField] private int chanceToDrop;

	private void Start()
	{
		maxHealth = health;
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
			int rnd = Random.Range(0, 100);
            if (rnd <= chanceToDrop)
            {
				Instantiate(objectToDrop, transform.position, Quaternion.identity);
            }
        }
    }

}
