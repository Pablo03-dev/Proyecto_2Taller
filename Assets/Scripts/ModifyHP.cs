using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ModifyHP : MonoBehaviour
{
	public bool destroyWhenActivated = false;
	public int healthChange = -1;

	private void OnCollisionEnter2D(Collision2D collisionData)
	{
		OnTriggerEnter2D(collisionData.collider);
	}

	private void OnTriggerEnter2D(Collider2D colliderData)
	{
		HPSystem healthScript = colliderData.gameObject.GetComponent<HPSystem>();
		if (healthScript != null)
		{
			healthScript.ModifyHealth(healthChange);

			if (destroyWhenActivated)
			{
				Destroy(this.gameObject);
			}
		}
	}
}
