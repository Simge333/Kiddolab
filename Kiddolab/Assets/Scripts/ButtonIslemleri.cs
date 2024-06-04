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
	public void LevelbirButton()
	{
		SceneManager.LoadScene(1);

	}
	public void LevelikiButton()
	{
		SceneManager.LoadScene(2);

	}
	public void LogoutButton()
	{

		Application.Quit();

	}
	public void LevelShowButton(GameObject levelPanel)
	{

		if (levelPanel.gameObject.CompareTag("levelPanel")) {
			levelPanel.SetActive(true);
		}
		
		


	}
	public void LevelcloseButton(GameObject levelPanel)
	{

		if (levelPanel.gameObject.CompareTag("levelPanel"))
		{
			levelPanel.SetActive(false);
		}




	}

}
