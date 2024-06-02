using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class DusmanScript : MonoBehaviour
{
	private NavMeshAgent _navmeshAgent;
	[SerializeField] private Transform hedefTransform;
	void Start()
	{
		_navmeshAgent = GetComponent<NavMeshAgent>();
		_navmeshAgent.updateUpAxis = false; // �arp��ma alg�lamas�n� devre d��� b�rak
		

	}


	void Update()
	{
		

		transform.LookAt(hedefTransform);
		_navmeshAgent.SetDestination(hedefTransform.position);
		
	}
	



}
