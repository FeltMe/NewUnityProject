using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoinCollector : MonoBehaviour
{
    private ulong Points = 0;
    public Text ScoreText;
    public void IncrementPoints()
    {
        Points++;
        ScoreText.text = Points.ToString();
    }
}
