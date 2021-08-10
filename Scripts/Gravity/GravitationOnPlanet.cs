using System;
using System.Collections.Generic;
using UnityEngine;

namespace Gravity
{
    public class GravitationOnPlanet : MonoBehaviour
    {
        [SerializeField] private float _gravity = -10f;

        private List<IGravityObject> _objectsOnPlanet = new List<IGravityObject>();

        private void FixedUpdate()
        {
            AttractObjectsOnPlanet();
        }

        private void AttractObjectsOnPlanet()
        {
            foreach (IGravityObject _object in _objectsOnPlanet)
            {
                _object.BeAttracted(transform.position, _gravity);
            }
        }

        private void OnTriggerEnter(Collider other)
        {
            AddObjectOnPlanet(other);
        }
        private void OnTriggerExit(Collider other)
        {
            RemoveObjectFromPlanet(other);
        }

        private void AddObjectOnPlanet(Collider _object)
        {
            IGravityObject iGravity = _object.GetComponent<IGravityObject>();
            if (iGravity != null)
                _objectsOnPlanet.Add(iGravity);
        }

        private void RemoveObjectFromPlanet(Collider _object)
        {
            IGravityObject iGravity = _object.GetComponent<IGravityObject>();
            if (iGravity != null)
                _objectsOnPlanet.Remove(iGravity);
        }
    }
}
