using UnityEngine;

namespace Gravity
{
    public class RigidbodyGravity : MonoBehaviour, IGravityObject
    {
        private Rigidbody _rb;

        private void Awake()
        {
            _rb = GetComponent<Rigidbody>();
        }

        public void BeAttracted(Vector3 direction, float magnitude)
        {
            _rb.AddForce(direction * magnitude);
        }

        public Vector3 GetPosition()
        {
            return _rb.position;
        }

        public float GetMass()
        {
            return _rb.mass;
        }
    }
}
