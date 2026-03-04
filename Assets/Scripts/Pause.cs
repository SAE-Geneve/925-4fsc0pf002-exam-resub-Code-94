using UnityEngine;

public class Pause : MonoBehaviour
{

    public bool isPaused = true;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public void OnPause()
    {
        if (isPaused == true)
        {
            Time.timeScale = 1;
            isPaused = false;
            Debug.Log("Here we go again");
            
        }
        else
        {
            Time.timeScale = 0;
            isPaused = true;
            Debug.Log("The game is paused");
        }
    }
}
