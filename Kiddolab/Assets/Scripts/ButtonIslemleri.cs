using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonIslemleri : MonoBehaviour
{
	public void OnButtonClick()
	{		
		// Bulunduðu sahnenin indisi alýp bir ekliyor bu þekilde bir sonraki sahneye geçmiþ oluyor.
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);

	}

}
