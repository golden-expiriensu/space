using UnityEngine;

namespace Gravity
{
    public interface IGravityObject
    {
        void BeAttracted(Vector3 direction, float Magnitude);
        Vector3 GetPosition();
        float GetMass();
    }
}
