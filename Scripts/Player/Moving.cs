using UnityEngine;

namespace Player
{
    public class Moving : MonoBehaviour
    {
        private Link _player;

        private void Awake()
        {
            _player = GetComponent<Link>();
        }

        public void Move(Vector3 direction)
        {
            Vector3 move = (transform.position + 
                transform.TransformDirection(direction) * _player.Stats.MoovingSpeed * Time.deltaTime);

            _player.Rigidbody.MovePosition(move);
        }
    }
}
