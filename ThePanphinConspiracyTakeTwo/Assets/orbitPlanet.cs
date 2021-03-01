using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class orbitPlanet : MonoBehaviour
{
    public Transform target;
    public float orbitDistance = 10.0f;
    public float orbitDegressPerSec = 180.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    void Orbit()
    {
        if (target != null)
        {
            // Keep at orbitDistance from target
            transform.position = target.position + (transform.position - target.position).normalized * orbitDistance;
            transform.RotateAround(target.position, Vector3.up, orbitDegressPerSec * Time.deltaTime);
        }
    }

    // Be sure target is done moving before updating this object's position
    void LateUpdate()
    {
        Orbit();
    }
}
