using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonIslemleri1 : MonoBehaviour
{
	public void OnButtonClick()
	{
	
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);

	}

	public GameObject bilgiPanel;

	public void FalseButtonClick()
	{
		StartCoroutine(ShowPanelForTimeAndReloadScene(bilgiPanel, 2f)); 
	}

	private IEnumerator ShowPanelForTimeAndReloadScene(GameObject panel, float duration)
	{
		panel.SetActive(true);
		Time.timeScale = 1;
		yield return new WaitForSeconds(duration);

		panel.SetActive(false);

		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
	}

}
