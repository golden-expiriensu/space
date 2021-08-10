using UnityEngine;

namespace Gravity
{
    public class PlayerGravity : MonoBehaviour, IGravityObject
    {
        private Player.Link _player;
        private float _rotDamp = 3f;

        private void Awake()
        {
            _player = GetComponent<Player.Link>();
        }

        private void FixedUpdate()
        {
            Stand();
        }

        public void BeAttracted(Vector3 direction, float magnitude)
        {
            _player.Rigidbody.AddForce(direction * magnitude);
        }

        public Vector3 GetPosition()
        {
            return transform.position;
        }

        public float GetMass()
        {
            return _player.Rigidbody.mass;
        }

        public void Stand()
        {
            Quaternion rotation = Quaternion.FromToRotation(transform.up, _player.SurfaceSlider.CurrentNormal);
            transform.rotation = Quaternion.Slerp(transform.rotation, rotation, _rotDamp * Time.fixedDeltaTime);
        }
    }
}
