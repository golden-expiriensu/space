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

            Quaternion rot = Quaternion.FromToRotation(transform.up, _player.Moving.LastMoveDirection);
            Vector3 move = rot * jump;

            _player.Rigidbody.AddForce(jump + move);
        }
    }
}
