using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeCounter : MonoBehaviour
{
    /// <summary>
    /// Play Time
    /// </summary>
    public float m_Time = 0.0f;

    /// <summary>
    /// CANVAS Text
    /// </summary>
    Text m_text;

    // Use this for initialization
    void Start()
    {
        // Get the Text Component
        m_text = GetComponent<Text>();

        // Reset the score
        m_Time = 0;
    }

    // Update is called once per frame
    void Update()
    {
        // Seconds
        m_Time += Time.deltaTime;
        // Set the Time per frame
        m_text.text = "Time: " + Mathf.Round(m_Time);
    }
}
