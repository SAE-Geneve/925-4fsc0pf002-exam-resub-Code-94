using UnityEngine;

public class SpeedUp : MonoBehaviour
{

    public bool acceleration;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public void OnSpeedUp()
    {
        if (acceleration == true)
        {
            Time.timeScale = 2;
            acceleration = false;
            Debug.Log("ACCELERATION");
        }
        else
        {
            Time.timeScale = 1;
            acceleration = true;
            Debug.Log("BACK to normal");
        }
    }
}
