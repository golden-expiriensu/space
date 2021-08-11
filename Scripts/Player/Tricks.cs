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
            Vector3 move = _player.Moving.LastMoveDirection;
            
            move *= _player.Stats.JumpDistanceForce * _player.Rigidbody.velocity.magnitude;

            _player.Rigidbody.AddForce(jump + move);
        }
    }
}
