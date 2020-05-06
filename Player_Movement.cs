using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace OuterWorldAttackers
{


	public class Player_Movement : MonoBehaviour
	{
		public float m_speed = 6.0f;
		public float m_gravity = -9.8f;

		private CharacterController m_charCont;

		// Start is called before the first frame update
		void Start()
		{
			m_charCont = GetComponent<CharacterController>(); //U need CharacterController to Player
		}


		void Update()
		{// Jumping
		 //if (Input.GetKeyDown(KeyCode.Space))
			{
				//if (transform.position.y <= 1.05f)
				{
					//	GetComponent<Rigidbody>().AddForce(Vector3.up * 1000);
				}
			}


			float deltaX = Input.GetAxis("Horizontal") * m_speed;
			float deltaZ = Input.GetAxis("Vertical") * m_speed;
			Vector3 movement = new Vector3(deltaX, 0, 0);
			movement = Vector3.ClampMagnitude(movement, m_speed);

			movement.y = m_gravity;


			movement *= Time.deltaTime;
			movement = transform.TransformDirection(movement);
			m_charCont.Move(movement);
		}
	}
}
