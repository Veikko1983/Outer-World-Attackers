using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace OuterWorldAttackers
{


	public class Shooting : MonoBehaviour
	{
		private AudioSource m_audioSrc;
		public GameObject bullet;
		public float speed = 5000f;
		public Animator m_Animator;
		void Start()
		{
			m_audioSrc = GetComponent<AudioSource>();
			m_Animator = GameObject.Find("Player").GetComponent<Animator>();
		}

		// Remember U Need a bullet and then EmptyGameObject to use this. U put this code to emptygameobject
		void Update()
		{
			if (Input.GetMouseButtonDown(0) && Veikkos_MenuManager.m_GamePaused == false)
			{
				m_audioSrc.Play();
				GameObject instBullet = Instantiate(bullet, transform.position, Quaternion.identity) as GameObject;
				Rigidbody instBulletRigidbody = instBullet.GetComponent<Rigidbody>();
				instBulletRigidbody.AddForce(Vector3.forward * speed);
				m_Animator.SetTrigger("Shooting");
			}
		}
	}
}
