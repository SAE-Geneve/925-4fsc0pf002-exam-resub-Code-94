using UnityEngine;
using UnityEngine.InputSystem;

public class RedLight : MonoBehaviour
{
    private Camera _camera;
    private bool _isGreen = true;

    void Start()
    {
        _camera = Camera.main;
    }

    void Update()
    {
        if (Mouse.current.leftButton.wasPressedThisFrame)
            CheckRaycastClick();
    }

    private void CheckRaycastClick()
    {
        Vector2 mousePos = Mouse.current.position.ReadValue();
        Ray ray = _camera.ScreenPointToRay(mousePos);

        if (Physics.Raycast(ray, out RaycastHit hit))
            OnClicked();
        
    }

    private void OnClicked()
    {
        _isGreen = !_isGreen;
        Debug.Log($"{gameObject.name} clicked — IsGreen ? {_isGreen}");
    }
}
