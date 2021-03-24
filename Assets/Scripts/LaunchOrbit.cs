using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SimpleKeplerOrbits;

public class LaunchOrbit : MonoBehaviour
{
    public SimpleKeplerOrbits.Vector3d bodyPosition;
    public SimpleKeplerOrbits.Vector3d bodyVelocity;
    public float attractorMass;
    public float gConst;
    public Transform attractorTransform;
    private SimpleKeplerOrbits.KeplerOrbitMover body;


    // Start is called before the first frame update
    void Start()
    {
        body = GetComponent<KeplerOrbitMover>();
        body.AttractorSettings.AttractorObject = attractorTransform;
        body.AttractorSettings.AttractorMass = attractorMass;
        body.AttractorSettings.GravityConstant = gConst;
        body.OrbitData = new KeplerOrbitData(
            position: bodyPosition,
            velocity: bodyVelocity,
            attractorMass: attractorMass,
            gConst: gConst);
        body.ForceUpdateViewFromInternalState();
    }

    // Update is called once per frame
    void Update()
    {
        body.ForceUpdateViewFromInternalState();
    }
}
