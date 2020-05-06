using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace OuterWorldAttackers
{


    public class DestroyObject : MonoBehaviour
    {
        void OnCollisionEnter(Collision col)
        {
            if (col.gameObject.name == "Enemy")
            {
                Destroy(col.gameObject);
            }
        }





        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}
