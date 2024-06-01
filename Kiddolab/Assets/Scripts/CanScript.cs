using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CanScript : MonoBehaviour
{
	public int currentHealth;
	[SerializeField] private int maxHealth;

	[SerializeField] private Image healthBarFillImage;
	public virtual void Awake()
	{
		currentHealth = maxHealth;
	}
	public void ChangeCurrentHealth(int value)
	{
		currentHealth += value;

		if (currentHealth > maxHealth)
		{
			currentHealth = maxHealth;
		}

		ChangeHealthBar();

		if (currentHealth <= 0)
		{
			Die();
		}
	}

	public void IncreaseHealth(int value)
	{
		ChangeCurrentHealth(value);
	}

	public void DecreaseHealth(int value)
	{
		ChangeCurrentHealth(-value);
	}

	private void ChangeHealthBar()
	{
		healthBarFillImage.fillAmount = (float)currentHealth / maxHealth;
	}

	public virtual void Die()
	{
		Destroy(this.gameObject);
	}
}