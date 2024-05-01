using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kameraScript : MonoBehaviour
{
	public Transform player, cameraTrans;

	void Update()
	{
		cameraTrans.LookAt(player);
	}
}
