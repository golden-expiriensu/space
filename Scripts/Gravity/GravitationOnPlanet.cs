using System;
using System.Collections.Generic;
using UnityEngine;

namespace Gravity
{
    public class GravitationOnPlanet : Gravitation
    {
        private List<IGravityObject> _objectsOnPlanet = new List<IGravityObject>();
        private Rigidbody _planetRigidbody;

        private void Awake()
        {
            _planetRigidbody = GetComponent<Rigidbody>();
        }

        private void FixedUpdate()
        {
            AttractObjectsOnPlanet();
        }

        private void AttractObjectsOnPlanet()
        {
            foreach (IGravityObject _object in _objectsOnPlanet)
            {
                Vector3 direction = _planetRigidbody.position - _object.GetPosition();
                float sqrDistance = direction.sqrMagnitude;
                float force = CalculateForceOfGravity(_object.GetMass(), _planetRigidbody.mass, sqrDistance);
                
                _object.BeAttracted(direction.normalized, force);
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
