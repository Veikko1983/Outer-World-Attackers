using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace OuterWorldAttackers
{



	public class PlayerMove : MonoBehaviour
	{
		[SerializeField] public float m_speed;
		[SerializeField] internal Rigidbody m_rigid;

		void Start()
		{
			m_rigid = GetComponent<Rigidbody>();
			{

			}


		}


		void Update()
		{
			// Jumping
			if (Input.GetKeyDown(KeyCode.Space))
			{
				if (transform.position.y <= 1.05f)
				{
					GetComponent<Rigidbody>().AddForce(Vector3.up * 800);
				}
			}




			//Player Move and Speed
			float Horizontal = Input.GetAxis("Horizontal");
			float Vertical = Input.GetAxis("Vertical");


			Vector3 move = new Vector3(Horizontal, 0.0f, Vertical);

			m_rigid.AddForce(move * m_speed);




		}
	}
}
