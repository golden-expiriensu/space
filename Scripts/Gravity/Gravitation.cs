using UnityEngine;

namespace Gravity
{
    public class Gravitation : MonoBehaviour
    {
        private const float G = 6.6743f * 10e-5f;

        protected static float CalculateForceOfGravity(float m1, float m2, float sqrDistance)
        {
            float F = G * (m1 * m2) / sqrDistance;
            return F;
        }
    }
}

