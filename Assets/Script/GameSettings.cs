using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using VektorenFormativ;

public class GameSettings : MonoBehaviour
{
    /// <summary>
    /// Planet
    /// </summary>
    public Planet m_Planet;
    /// <summary>
    /// Player
    /// </summary>
    public Player m_Player;
    /// <summary>
    /// GUNIT Power
    /// </summary>
    public float GUnit = 5f;

    private void Update()
    {
        MagnetField();
    }

    void MagnetField()
    {
        // Calculate the distance between 2 obj.
        float distance = Mathf.Sqrt(
            Mathf.Pow(m_Planet.m_Center.X - m_Player.m_Position.X, 2)
            + Mathf.Pow(m_Planet.m_Center.Y - m_Player.m_Position.Y, 2)
            + Mathf.Pow(m_Planet.m_Center.Z - m_Player.m_Position.Z, 2));
        // Set the Player Position (Translate or Rigidbody.Addforce)
        m_Player.m_Position -= Matrix.TRS(new Vector(0, 0, 0), m_Player.m_Rotation, m_Player.m_Scale) * new Vector(1, 1, 0) * ((((9.81f) / distance) / distance) * distance * Time.deltaTime);
        // Set the global transform.position
        m_Player.transform.position = Player.CONVERT_VECTOR_UNITY_TO_NORMAL(m_Player.m_Position);
    }
}
