using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using VektorenFormativ;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    #region CONVERTER
    public static Vector CONVERT_VECTOR_NORMAL_TO_UNITY(Vector3 _vector)
    {
        return new Vector(_vector.x, _vector.y, _vector.z);
    }

    public static Vector3 CONVERT_VECTOR_UNITY_TO_NORMAL(Vector _vector)
    {
        return new Vector3(_vector.X, _vector.Y, _vector.Z);
    }
    #endregion

    /// <summary>
    /// The Power of the Rocket
    /// </summary>
    public float m_ForceValue = 1f;
    /// <summary>
    /// The speed of rotation
    /// </summary>
    public float m_RotationSpeed = 1f;
    /// <summary>
    /// Radius of Player
    /// </summary>
    public float m_Radius;
    /// <summary>
    /// Body of the player
    /// </summary>
    public Sphere m_Player;
    /// <summary>
    /// Position of player
    /// </summary>
    public Vector m_Position = new Vector();
    /// <summary>
    /// Player Rotation
    /// </summary>
    public Vector m_Rotation = new Vector();
    /// <summary>
    /// Scale of Player
    /// </summary>
    public Vector m_Scale = new Vector();
    /// <summary>
    /// Get Planet
    /// </summary>
    public Planet m_Planet;
    /// <summary>
    /// Get Platform
    /// </summary>
    public Platform m_Platform;
    /// <summary>
    /// Player Health
    /// </summary>
    public int m_PlayerHealth = 100;
    /// <summary>
    /// Player Alive/Died
    /// </summary>
    public bool m_PlayerAlive = true;

    public Vector m_Forward;


    // Start
    private void Start()
    {
        // Set the Scale of the Player
        m_Scale = CONVERT_VECTOR_NORMAL_TO_UNITY(transform.localScale);
        // Set the Rotation of the Player
        m_Rotation = CONVERT_VECTOR_NORMAL_TO_UNITY((transform.rotation.eulerAngles));
        // Set the Position of the Player
        m_Position = CONVERT_VECTOR_NORMAL_TO_UNITY(transform.position);
        // Sphere
        m_Player = new Sphere(m_Position, m_Radius);
        // Forward Vector
        m_Forward = CONVERT_VECTOR_NORMAL_TO_UNITY(transform.forward);
    }

    // Update is called once per frame
    void Update()
    {
        if (m_PlayerAlive)
        {
            // Set the Scale of the Player
            m_Scale = CONVERT_VECTOR_NORMAL_TO_UNITY(transform.localScale);
            // Set the Rotation of the Player
            m_Rotation = CONVERT_VECTOR_NORMAL_TO_UNITY((transform.eulerAngles));
            // Set the Position of the Player
            m_Position = CONVERT_VECTOR_NORMAL_TO_UNITY(transform.position);
            // Forward Vector
            m_Forward = CONVERT_VECTOR_NORMAL_TO_UNITY(transform.forward);
            // Position Set (if player is alive)
            transform.position = CONVERT_VECTOR_UNITY_TO_NORMAL(m_Position);
            // Rotation Set (if player is alive)
            transform.eulerAngles = CONVERT_VECTOR_UNITY_TO_NORMAL(m_Rotation);
            // Scale Set (if player is alive)
            transform.localScale = CONVERT_VECTOR_UNITY_TO_NORMAL(m_Scale);
            // Sphere
            m_Player = new Sphere(m_Position, m_Radius);

            // Call Move
            Movement();
            // If you hit the Platform, you WON!
            if (Collisions.SphereInSphere(m_Platform.m_Platform, m_Player))
            {
                SceneManager.LoadScene(1);
            }
            // If you hit the Plane, you LOSE!
            if (Collisions.SphereInSphere(m_Planet.m_PlanetSphere, m_Player))
            {
                SceneManager.LoadScene(2);
            }
        }
    }

    // Player Movement
    void Movement()
    {
        // Position (TRS = Transform,Rotation,Scale)
        if (Input.GetKey(KeyCode.Space))
        {
            m_Position += Matrix.TRS(new Vector(0, 0, 0), m_Rotation, m_Scale) * new Vector(0, 1, 0) * Time.deltaTime * m_ForceValue;
            transform.position = CONVERT_VECTOR_UNITY_TO_NORMAL(m_Position);
        }

        if (Input.GetAxisRaw("Horizontal") != 0)
        {
            m_Rotation += new Vector(0, 0, -Input.GetAxis("Horizontal") * m_RotationSpeed * Time.deltaTime);
            transform.eulerAngles = CONVERT_VECTOR_UNITY_TO_NORMAL(m_Rotation);
        }
    }
}