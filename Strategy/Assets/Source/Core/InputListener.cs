using Player;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Core
{
    public class InputListener : MonoBehaviour
    {
        private PlayerController _controller;
        public void Construct(PlayerController controller)
        {
            _controller = controller;
        }
        private void Update()
        {
            if (_controller != null)
            {
                if (Input.GetKeyDown(KeyCode.G))
                {
                    _controller.Attack();
                }
            }
        }
    }
}