using System.Collections.Generic;
using UnityEngine;

namespace Player
{
    public class Control : MonoBehaviour
    {
        private Link _player;

        private void Awake()
        {
            _player = GetComponent<Link>();
        }

        //private enum ControlType
        //{
        //    moveForward
        //}
        //private Dictionary<ControlType, KeyCode> ControlBind = new Dictionary<ControlType, KeyCode>
        //{
        //    { ControlType.moveForward, KeyCode.W }
        //};

        void Update()
        {
            float vertical = Input.GetAxis("Vertical");
            float horizontal = Input.GetAxis("Horizontal");
            Vector3 direction = new Vector3(horizontal, 0, vertical);
            if(direction.sqrMagnitude >= 0.01f)// && _player.CharacterController.isGrounded)
            {
                _player.Moving.Move(direction);
            }
        }
    }
}
