using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace OuterWorldAttackers
{


	public class Waypoints : MonoBehaviour
	{//U need emptygame object to do this
		public GameObject[] waypoints;
		int current = 0;
		float rotSpeed;
		public float m_speed;
		float WPradius = 1;



		void Start()
		{

		}


		void Update()
		{
			if (Vector3.Distance(waypoints[current].transform.position, transform.position) < WPradius)
			{
				current++;
				if (current >= waypoints.Length)
				{
					current = 0;
				}
			}
			transform.position = Vector3.MoveTowards(transform.position, waypoints[current].transform.position, Time.deltaTime * m_speed);


		}
	}
}
