using System;
using System.Collections;
using UnityEngine;

namespace Player
{
    public class Tricks : MonoBehaviour
    {
        private Link _player;

        private void Awake()
        {
            _player = GetComponent<Link>();
        }

        public void Jump()
        {
            Vector3 jump = _player.SurfaceSlider.CurrentNormal * _player.Stats.JumpHeightForce;

            Vector3 move = Vector3.zero;
            if (_player.Rigidbody.velocity.magnitude >= .1f)
            {
                Quaternion rot = Quaternion.FromToRotation(transform.up, _player.Moving.LastMoveDirection);
                move = rot * jump;
            }

            _player.Rigidbody.AddForce(jump + move);
        }
    }
}
