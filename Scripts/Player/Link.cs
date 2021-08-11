using UnityEngine;

namespace Player
{
    public class Link : MonoBehaviour
    {
        public PhysicsMoving Moving { get; private set; }
        public Tricks Tricks { get; private set; }
        public SurfaceSlider SurfaceSlider { get; private set; }
        public Rotating Rotating { get; private set; }
        public Rigidbody Rigidbody { get; private set; }
        public Gravity.PlayerGravity PlayerGravity { get; private set; }
        public Stats Stats { get; private set; }
        [SerializeField] Transform model;
        public Transform Model 
        {
            get
            {
                return model;
            }
        }

        [SerializeField] private Transform cameraTransform;
        public Transform CameraTransform
        {
            get { return cameraTransform; }
        }


        private void Awake()
        {
            Moving = GetComponent<PhysicsMoving>();
            Tricks = GetComponent<Tricks>();
            SurfaceSlider = GetComponent<SurfaceSlider>();
            Rotating = GetComponent<Rotating>();
            Rigidbody = GetComponent<Rigidbody>();
            PlayerGravity = GetComponent<Gravity.PlayerGravity>();
            Stats = GetComponent<Stats>();
        }
    }
}
