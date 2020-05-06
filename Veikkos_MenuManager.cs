using UnityEngine;
using UnityEngine.SceneManagement;

namespace OuterWorldAttackers
{

	public class Veikkos_MenuManager : MonoBehaviour
	{
		[SerializeField] public GameObject m_pauseMenuUI;
		[SerializeField] public bool m_GameHasBeenPaused = false;
		[SerializeField] private Shooting m_Shoooot;

		public static bool m_GamePaused = false;

		void Awake()
		{
			m_pauseMenuUI.SetActive(false);
		}

		void Update()
		{
			if (Input.GetKeyDown(KeyCode.Escape))
			{
				if (m_GameHasBeenPaused)
				{
					Resume();
				}
				else
				{
					Pause();
				}
			}
		}

		public void Resume()
		{
			m_GamePaused = false;
			m_pauseMenuUI.SetActive(false);

			Time.timeScale = 1f;
			m_GameHasBeenPaused = false;
			Cursor.visible = false;
			Cursor.lockState = CursorLockMode.Locked;
			//m_Shoooot.bullet.SetActive(true);
		}

		void Pause()
		{
			m_GamePaused = true;
			m_pauseMenuUI.SetActive(true);

			Time.timeScale = 0f;
			m_GameHasBeenPaused = true;
			Cursor.visible = true;
			Cursor.lockState = CursorLockMode.None;
			//m_Shoooot.bullet.SetActive(false);
		}

		public void QuitGame()
		{
			Application.Quit();
		}		

		public void Restart()
		{
			Time.timeScale = 1;
			SceneManager.LoadScene(1);
		}
	}
}