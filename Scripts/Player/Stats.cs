using UnityEngine;

namespace Player
{
    public class Stats : MonoBehaviour
    {
        [SerializeField] private float _moovingSpeed = 5f;
        public float MoovingSpeed
        {
            get
            {
                return _moovingSpeed;
            }
        }

        [SerializeField] private float _jumpForce = 50f;
        public float JumpForce
        {
            get
            {
                return _jumpForce;
            }
        }
    }
}
