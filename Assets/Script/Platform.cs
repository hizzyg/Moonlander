using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using VektorenFormativ;

public class Platform : MonoBehaviour
{
    /// <summary>
    /// Scale of Planet
    /// </summary>
    public Vector m_Scale;
    /// <summary>
    /// Rotation of Planet
    /// </summary>
    public Vector m_Rotation;
    /// <summary>
    /// Forward of Planet
    /// </summary>
    public Vector m_Forward;
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

    // Use this for initialization
    void Start()
    {
        // Forward Vector
        m_Forward += Player.CONVERT_VECTOR_NORMAL_TO_UNITY(transform.forward);
        // Set the Scale of the Player
        m_Scale = Player.CONVERT_VECTOR_NORMAL_TO_UNITY(transform.localScale);
        // Set the Rotation of the Player
        m_Rotation = Player.CONVERT_VECTOR_NORMAL_TO_UNITY((transform.rotation.eulerAngles));
        // Set the Position of the Player
        m_Position = Player.CONVERT_VECTOR_NORMAL_TO_UNITY(transform.position);
        // Set the Platform
        m_Platform = new Sphere(m_Position, m_Radius);
    }
    private void Update()
    {
        // Forward Vector
        m_Forward = (Player.CONVERT_VECTOR_NORMAL_TO_UNITY(transform.forward));
    }
}
