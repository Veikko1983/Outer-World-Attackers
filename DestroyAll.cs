using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace OuterWorldAttackers
{


	public class DestroyAll : MonoBehaviour
	{
		[SerializeField] public ParticleSystem m_DestroyEffect;
		[SerializeField] public MeshRenderer m_Mesh;
		void Start()
		{
			
			
			

		}
		void OnCollisionEnter(Collision col)
		{
			if (col.gameObject.CompareTag("Wall"))
			{
			 m_Mesh.enabled = false;
			 m_DestroyEffect.Play();
			
			 Debug.Log("akkakakak");
			 
			 StartCoroutine(WaitS());
				
			

				

			}
		}

		IEnumerator WaitS()
		{
			
			yield return new WaitForSeconds(3);
			
			Destroy(gameObject);


		}


		void Update()
		{

		}
	}
}
