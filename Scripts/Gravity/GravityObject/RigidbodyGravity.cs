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

        public void BeAttracted(Vector3 center, float gravity)
        {
            Vector3 gravityUp = (transform.position - center).normalized;
            _rb.AddForce(gravityUp * gravity);
        }
    }
}
