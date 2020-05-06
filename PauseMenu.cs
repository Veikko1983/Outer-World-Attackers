using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace OuterWorldAttackers
{


	public class PauseMenu : MonoBehaviour
	{
		public static bool m_GameIsPaused = false;
		public GameObject m_pauseMenuUI;

		void Update()
		{
			if (Input.GetKeyDown(KeyCode.Escape))
			{

			}
			if (m_GameIsPaused)
			{
				Resume();
			}
			else
			{
				Pause();
			}
		}

		void Resume()
		{
			m_pauseMenuUI.SetActive(false);
			Time.timeScale = 1f;
			m_GameIsPaused = false;
		}
		void Pause()
		{
			m_pauseMenuUI.SetActive(true);
			Time.timeScale = 0f;
			m_GameIsPaused = true;
		}
	}
}
