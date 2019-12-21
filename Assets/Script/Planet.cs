using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using VektorenFormativ;

public class Planet : MonoBehaviour
{
    /// <summary>
    /// Body of the Planet
    /// </summary>
    public Sphere m_PlanetSphere;
    /// <summary>
    /// Position of Planet
    /// </summary>
    public Vector m_Center = new Vector(0, 0, 0);
    /// <summary>
    /// Radius
    /// </summary>
    public float m_Radius;

    /// <summary>
    /// Mass
    /// </summary>
    public float m_Mass = 1;

    // Use this for initialization
    void Start()
    {
        // Set the Body of the Planet
        m_PlanetSphere = new Sphere(new Vector(0, 0, 0), m_Radius);
    }
}
