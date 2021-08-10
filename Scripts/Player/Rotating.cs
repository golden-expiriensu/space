using UnityEngine;

namespace Player
{
    public class Rotating : MonoBehaviour
    {
        private Link _player;

        private float _turnSmoothTime = 0.1f;
        private float _refTurnSmooth;

        private void Awake()
        {
            _player = GetComponent<Link>();
        }

        private void FixedUpdate()
        {
            TurnAfterCamera();
        }

        public void TurnAfterCamera()
        {
            float yDifference = _player.CameraTransform.eulerAngles.y - _player.Model.eulerAngles.y;
            yDifference = Mathf.SmoothDampAngle(
                0,
                yDifference,
                ref _refTurnSmooth,
                _turnSmoothTime);
            Quaternion turn = Quaternion.Euler(0, yDifference, 0);
            _player.Model.rotation *= turn;
        }
    }
}