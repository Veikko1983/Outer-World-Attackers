using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace OuterWorldAttackers
{


    public class AutoMove : MonoBehaviour
    {
        public float m_speed;
        void Start()
        {

        }


        void Update()
        {
            transform.Translate(Vector3.forward * Time.deltaTime * m_speed);
        }
    }
}
