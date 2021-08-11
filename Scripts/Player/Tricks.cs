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
            _player.Rigidbody.AddForce(_player.SurfaceSlider.CurrentNormal * _player.Stats.JumpForce);
        }
    }
}
