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
    public Vector m_Position;
    /// <summary>
    /// Scale of Planet
    /// </summary>
    public Vector m_Scale;
    /// <summary>
    /// Rotation of Planet
    /// </summary>
    public Vector m_Rotation;
    /// <summary>
    /// Center of Planet
    /// </summary>
    public Vector m_Center = new Vector(0, 0, 0);
    /// <summary>
    /// Radius
    /// </summary>
    public float m_Radius;

    // Use this for initialization
    void Start()
    {
        // Set the Body of the Planet
        m_PlanetSphere = new Sphere(new Vector(0, 0, 0), m_Radius);
        // Set the Position of Planet
        m_Position = Player.CONVERT_VECTOR_NORMAL_TO_UNITY(transform.position);
        // Set the Rotation of Planet
        m_Rotation = Player.CONVERT_VECTOR_NORMAL_TO_UNITY(transform.rotation.eulerAngles);
        // Set the Scale of Planet
        m_Scale = Player.CONVERT_VECTOR_NORMAL_TO_UNITY(transform.localScale);
    }

    // Update is called once per frame
    void Update()
    {
        // Set the Body of the Planet
        m_PlanetSphere = new Sphere(new Vector(0, 0, 0), m_Radius);
        // Set the Position of Planet
        m_Position = Player.CONVERT_VECTOR_NORMAL_TO_UNITY(transform.position);
        // Set the Rotation of Planet
        m_Rotation = Player.CONVERT_VECTOR_NORMAL_TO_UNITY(transform.rotation.eulerAngles);
        // Set the Scale of Planet
        m_Scale = Player.CONVERT_VECTOR_NORMAL_TO_UNITY(transform.localScale);
    }
}
