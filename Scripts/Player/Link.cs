using UnityEngine;

namespace Player
{
    public class Link : MonoBehaviour
    {
        public Moving Moving { get; private set; }
        public SurfaceSlider SurfaceSlider { get; private set; }
        public Rotating Rotating { get; private set; }
        public Rigidbody Rigidbody { get; private set; }
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
            Moving = GetComponent<Moving>();
            SurfaceSlider = GetComponent<SurfaceSlider>();
            Rotating = GetComponent<Rotating>();
            Rigidbody = GetComponent<Rigidbody>();
            Stats = GetComponent<Stats>();
        }
    }
}
