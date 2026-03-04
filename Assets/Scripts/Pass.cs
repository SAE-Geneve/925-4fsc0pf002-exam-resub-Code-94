using System;
using UnityEngine;
using UnityEngine.Events;
public class Pass : MonoBehaviour
{
    
    public UnityEvent pointToAdd;
    

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Train"))
        {
            pointToAdd.Invoke();
        }
    }
}
