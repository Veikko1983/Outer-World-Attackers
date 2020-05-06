using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

namespace OuterWorldAttackers
{


	public class Timer : MonoBehaviour
	{
		private float startTime;
		public Text timerText;

		void Start()
		{
			startTime = Time.time;


		}


		void Update()
		{
			float t = Time.time - startTime;

			string minutes = ((int)t / 60).ToString();
			string seconds = (t % 60).ToString();

			timerText.text = minutes + ":" + seconds;

			
			
		}

	}
}
		
	


		
	
		
    

