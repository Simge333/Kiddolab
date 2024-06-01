using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KartIslemleri : MonoBehaviour
{
	public float destroyDelay = 0.2f; // Yok olma gecikme s�resi (saniye)

	private void OnTriggerEnter(Collider other)
	{
		// �arp��t���m�z nesnenin etiketini kontrol et
		if (other.gameObject.CompareTag("Player"))
		{
			Invoke("DestroyObject", destroyDelay);
		}
	}
	void DestroyObject()
	{
		// Nesneyi yok et
		Destroy(gameObject);
	}
}
