using System.Collections;

using System.Collections.Generic;
using UnityEngine;

namespace OuterWorldAttackers
{



	public class TimerDestroy : MonoBehaviour
	{
		public float interval;





		void Start()
		{
			Destroy(gameObject, interval);
		}

		// Update is called once per frame
		void Update()
		{

		}
	}
}
