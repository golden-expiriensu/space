using UnityEngine;

namespace Gravity
{
    public interface IGravityObject
    {
        void BeAttracted(Vector3 center, float gravity);
    }
}
