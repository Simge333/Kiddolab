using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonIslemleri : MonoBehaviour
{
	public void OnButtonClick()
	{
		// Ýstenilen sahnenin adýný SceneManager ile yükleyebiliriz.
		// Örneðin, "YeniSahne" adlý bir sahneye geçmek için:
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);

	}

}
