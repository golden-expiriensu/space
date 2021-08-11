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

        [SerializeField] private float _jumpHeightForce = 150f;
        public float JumpHeightForce
        {
            get
            {
                return _jumpHeightForce;
            }
        }

        [SerializeField] private float _jumpDistanceForce = 250f;
        public float JumpDistanceForce
        {
            get
            {
                return _jumpDistanceForce;
            }
        }
    }
}
