using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonIslemleri : MonoBehaviour
{
	public void OnButtonClick()
	{		
		// Bulundu�u sahnenin indisi al�p bir ekliyor bu �ekilde bir sonraki sahneye ge�mi� oluyor.
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);

	}

}
