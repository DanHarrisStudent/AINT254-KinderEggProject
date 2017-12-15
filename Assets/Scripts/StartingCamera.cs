using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ISS
{
    public class StartingCamera : MonoBehaviour
    {

        [SerializeField]
        private MoveCharacter scrpit;

    private void StartFollowPlayer()
        {
            scrpit.SetCameraAnimation(true);
        }

    }
}


