using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OyuncuScript : MonoBehaviour
{
	public Animator playerAnim;
	public Rigidbody playerRigid;
	public float w_speed, wb_speed, ro_speed;
	public bool walking;
	public Transform playerTrans;
	[SerializeField] GameObject soruPaneli;
	

	public GameObject[] kalpler;
	public int can=5, maxcan=5,currentcan;

	private bool canProtected = false;


	private void Start()
	{
		Time.timeScale = 1;


	}
	void FixedUpdate()
	{
		if (Input.GetKey(KeyCode.W))
		{
			playerRigid.velocity = transform.forward * w_speed;
		}
		if (Input.GetKey(KeyCode.S))
		{
			playerRigid.velocity = -transform.forward * wb_speed;
		}
		
	}

	#region Karakter Hareket Ýþlemleri
	void Update()
	{
		if (Input.GetKeyDown(KeyCode.W))
		{
			playerAnim.SetTrigger("walk");
			playerAnim.ResetTrigger("idle");
			walking = true;
			//steps1.SetActive(true);
		}
		if (Input.GetKeyUp(KeyCode.W))
		{
			playerAnim.ResetTrigger("walk");
			playerAnim.SetTrigger("idle");
			walking = false;
			//steps1.SetActive(false);
		}
		if (Input.GetKeyDown(KeyCode.S))
		{
			playerAnim.SetTrigger("walkback");
			playerAnim.ResetTrigger("idle");
			walking= true;
			//steps1.SetActive(true);
		}
		if (Input.GetKeyUp(KeyCode.S))
		{
			playerAnim.ResetTrigger("walkback");
			playerAnim.SetTrigger("idle");
			walking = false;
			//steps1.SetActive(false);
		}
		if (Input.GetKey(KeyCode.A))
		{
			playerTrans.Rotate(0, -ro_speed * Time.deltaTime, 0);
		}
		if (Input.GetKey(KeyCode.D))
		{
			playerTrans.Rotate(0, ro_speed * Time.deltaTime, 0);
		}

		if (can <= 0)
		{
			Debug.Log("gameover");
		}
	  }
	#endregion

	void can_sistemi()
	{
		
		
		for (int i = 0; i < maxcan; i++)
		{
			kalpler[i].SetActive(false);
		}

		for (int i = 0; i < can; i++)
		{
			kalpler[i].SetActive(true);
		}
		
		
	}

	#region Bitiþ noktasi ve Özellik kartý iþlemleri
	private void OnCollisionEnter(Collision collision)
	{
		if (collision.gameObject.CompareTag("bitisnok"))
		{
			soruPaneli.SetActive(true);
			Time.timeScale = 0;
		}


		if (collision.gameObject.CompareTag("Enemy"))
		{
			if (!canProtected)
			{
				can -= 1;
				can_sistemi();
			}
			//can -= 1;
			
			//can_sistemi();
			
		}
		
		
	}
	private void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.CompareTag("CanYenileme"))
		{
			can = 5;
			for (int i = 0; i < can; i++)
			{
				kalpler[i].SetActive(true);
			}
		}

		if (other.gameObject.CompareTag("olumsuzluk"))
		{
			if (!canProtected)
			{
				StartCoroutine(ProtectCan());
			}

		}
	}

	private IEnumerator ProtectCan()
	{
		canProtected = true;
		yield return new WaitForSeconds(3);
		canProtected = false;
	}


	#endregion


}


