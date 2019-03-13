using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    /// <summary>
    /// Score
    /// </summary>
    public int m_Score;
    /// <summary>
    /// Score Text
    /// </summary>
    public Text m_text;

    // Use this for initialization
    void Start()
    {
        m_Score = 0;
    }

    // Update is called once per frame
    void Update()
    {
        m_text.text = "Score: " + m_Score;
    }
}
