using UnityEngine;

namespace Player
{
    public class PhysicsMoving : MonoBehaviour
    {
        private Link _player;
        public Vector3 LastMoveDirection { get; private set; } = Vector3.zero;

        private void Awake()
        {
            _player = GetComponent<Link>();
        }

        public void Move(Vector3 direction)
        {
            Vector3 offset = transform.TransformDirection(direction) * _player.Stats.MoovingSpeed * Time.deltaTime;
            Vector3 move = (transform.position + offset);
            
            _player.Rigidbody.MovePosition(move);

            LastMoveDirection = offset.normalized;
        }
    }
}
