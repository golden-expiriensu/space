using UnityEngine;

namespace Gravity
{
    public class PlayerGravity : MonoBehaviour, IGravityObject
    {
        public Transform GroundCheckSphereOrigin;
        private float _groundCheckSphereRadius = 0.1f;
        private LayerMask _groundLayer;

        private Player.Link _player;
        private float _standDamp = 0.1f;

        private void Awake()
        {
            _groundLayer = LayerMask.GetMask("Ground");
            _player = GetComponent<Player.Link>();
        }

        public void BeAttracted(Vector3 planetCenter, float gravity)
        {
            Vector3 gravityDirection = (transform.position - planetCenter).normalized;
            _player.Rigidbody.AddForce(gravityDirection * gravity);

            Stand(planetCenter);
        }

        private void Stand(Vector3 planetCenter)
        {
            Vector3 localUp = transform.up;
            Vector3 gravityUp = (transform.position - planetCenter).normalized;

            Quaternion targetRotation = Quaternion.FromToRotation(localUp, gravityUp) * transform.rotation;
            transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, _standDamp);
        }

        public bool IsGrounded()
        {
            return Physics.CheckSphere(GroundCheckSphereOrigin.position, _groundCheckSphereRadius, _groundLayer);
        }
    }
}
