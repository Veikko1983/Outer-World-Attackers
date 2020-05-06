using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace OuterWorldAttackers
{


	public class Restart : MonoBehaviour
	{
		public void RestartGame()
		{
			SceneManager.LoadScene(1);
			print("238r8");
		}
	}
}
