using UnityEngine;
using UnityEngine.Events;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    public int score;

    public void AddPoint()
    {
        score++;
        GetComponent<TextMeshProUGUI>().text = $"Score :" + score;
    }
}
