using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace OuterWorldAttackers
{


	public class GameOverTrigger : MonoBehaviour
	{
		//public Timer m_Timeee;

		// this works any Object with Collider
		void OnTriggerEnter(Collider other)
		{
			if (other.tag == "Enemy")
			//PlayerPrefs.SetString("OWA", m_Timeee.timerText.text);
			//PlayerPrefs.Save();
			SceneManager.LoadScene(2);
			
		}


	}
}