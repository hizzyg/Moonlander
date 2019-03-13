using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using VektorenFormativ;

public class Camera : MonoBehaviour
{
    /// <summary> 
    /// store the player
    /// </summary>
    public Player player;
    /// <summary>
    /// Position of Camera
    /// </summary>
    public Vector m_Position;

    private void Start()
    {
        m_Position = Player.CONVERT_VECTOR_NORMAL_TO_UNITY(transform.position);
    }
    // Update is called once per frame
    void Update()
    {
        Transform();
    }
    // Set Camera Transform to player transform
    private void Transform()
    {
        m_Position = player.m_Position;
        m_Position.Z = -10f;
        transform.position = Player.CONVERT_VECTOR_UNITY_TO_NORMAL(m_Position);
    }
}
