using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace OuterWorldAttackers
{


    public class CursorHideShow : MonoBehaviour
    {


        void Start()
        {
            Cursor.visible = false;
            Cursor.lockState = CursorLockMode.Locked;
        }


        void Update()
        {

        }
    }
}
