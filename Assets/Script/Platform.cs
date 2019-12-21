using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using VektorenFormativ;

public class Platform : MonoBehaviour
{

    /// <summary>
    /// Forward of Position
    /// </summary>
    public Vector m_Position;
    /// <summary>
    /// Forward of Platform
    /// </summary>
    public Sphere m_Platform;
    /// <summary>
    /// Radius of Planet
    /// </summary>
    public float m_Radius;

    void Start()
    {
        // Set the Position of the platform
        m_Position = Player.CONVERT_VECTOR_NORMAL_TO_UNITY(transform.position);
        // Set the Platform
        m_Platform = new Sphere(m_Position, m_Radius);
    }
}
