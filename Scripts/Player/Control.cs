﻿using System.Collections.Generic;
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

        private enum ControlType
        {
            TurnLeft,
            TurnRight,
            Jump,
        }
        private Dictionary<ControlType, KeyCode> ControlBind = new Dictionary<ControlType, KeyCode>
        {
            { ControlType.TurnLeft, KeyCode.Q },
            { ControlType.TurnRight, KeyCode.E },
            { ControlType.Jump, KeyCode.Space },
        };

        void Update()
        {
            float vertical = Input.GetAxis("Vertical");
            float horizontal = Input.GetAxis("Horizontal");
            Vector3 direction = new Vector3(horizontal, 0, vertical);

            if(_player.PlayerGravity.IsGrounded())
            {
                if (direction.sqrMagnitude >= 0.01f)
                {
                    _player.Moving.Move(direction); 
                }

                if (Input.GetKey(ControlBind[ControlType.Jump]))
                    _player.Tricks.Jump();

                if (Input.GetKey(ControlBind[ControlType.TurnLeft]))
                    _player.Rotating.TurnLeft();

                if (Input.GetKey(ControlBind[ControlType.TurnRight]))
                    _player.Rotating.TurnRight();
            }

        }
    }
}
