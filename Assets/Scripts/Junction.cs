using System.Collections.Generic;
using UnityEditorInternal;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.Splines;

public class Junction : MonoBehaviour
{

    [SerializeField] private List<SplineContainer> _outs;

    public SplineContainer NextTrack => _outs[_nextTrackIdx];
    
    private Camera _camera;
    private SplineContainer _nextTrack;
    private int _nextTrackIdx = 0;
    
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
        _nextTrackIdx++;
        if (_nextTrackIdx >= _outs.Count) _nextTrackIdx = 0;
        
        Debug.Log($"{gameObject.name} clicked — Next Track ? {_outs[_nextTrackIdx]}");
    }
}
