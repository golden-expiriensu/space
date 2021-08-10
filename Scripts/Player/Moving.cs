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
            float targetAngle = Mathf.Atan2(direction.x, direction.z) * Mathf.Rad2Deg + _player.Model.eulerAngles.y;
            Vector3 moveDirection = Quaternion.Euler(0, targetAngle, 0) * Vector3.forward;
            Vector3 directionAlongSurface = _player.SurfaceSlider.Project(moveDirection);
            Vector3 offset = directionAlongSurface * _player.Stats.MoovingSpeed * Time.deltaTime;

            _player.Rigidbody.MovePosition(_player.Rigidbody.position + offset);
        }
    }
}
