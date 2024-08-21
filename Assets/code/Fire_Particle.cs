using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fire_Particle : MonoBehaviour
{
    public ParticleSystem Particle_System;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Space))
            fire();
    }

    void fire()
    {
        Particle_System.Emit(1);
    }
}
