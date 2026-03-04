using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class Chronometre : MonoBehaviour
{

    [SerializeField] private TextMeshProUGUI chrono;

    private GameManager _gameManager;
    public float threshold = 0;

    public float elapsedTime = 40f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        chrono.text = $"{elapsedTime} : {threshold}";
    }

    // Update is called once per frame
    void Update()
    {
        elapsedTime += Time.deltaTime;

        if (elapsedTime <= threshold)
        {
            SceneManager.LoadSceneAsync(2);
        }
    }
}
