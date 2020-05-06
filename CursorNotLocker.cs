using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace OuterWorldAttackers
{


	public class CursorNotLocker : MonoBehaviour
	{


		void Start()
		{
			Cursor.visible = true;
			Cursor.lockState = CursorLockMode.None;
		}


		void Update()
		{

		}
	}
}
