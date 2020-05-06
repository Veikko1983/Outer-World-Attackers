using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace OuterWorldAttackers
{

	public class MainMenu : MonoBehaviour
	{

		public void PlayGame()
		{
			Time.timeScale = 1f;
			SceneManager.LoadScene(1);
		}

		public void QuitGame()
		{
			Debug.Log("QUIT!");
			Application.Quit();
		}

	}
}