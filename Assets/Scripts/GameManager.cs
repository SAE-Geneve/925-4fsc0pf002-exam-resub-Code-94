using UnityEngine;
using UnityEngine.SceneManagement;
public class GameManager : MonoBehaviour
{
    public void OnGameOver()
    {
        SceneManager.UnloadSceneAsync(2);
    }
}
