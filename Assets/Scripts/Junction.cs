using System.Collections;
using System.Collections.Generic;
using UnityEditorInternal;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.Splines;

public class Junction : MonoBehaviour
{

    [SerializeField] private List<SplineContainer> _outs;
    [SerializeField] private GameObject greenFlag;
    [SerializeField] private GameObject redFlag;
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
        
        greenFlag.SetActive(false);
        redFlag.SetActive(true);
        if (Mouse.current.leftButton.wasPressedThisFrame)
            CheckRaycastClick();
    }

    private void CheckRaycastClick()
    {
        Vector2 mousePos = Mouse.current.position.ReadValue();
        Ray ray = _camera.ScreenPointToRay(mousePos);

        if (Physics.Raycast(ray, out RaycastHit hit))
        {
            StartCoroutine(FlagAppearance(2f));


        }
            
        
    }

    private void OnClicked()
    {
        _nextTrackIdx++;
        if (_nextTrackIdx >= _outs.Count) _nextTrackIdx = 0;
        
        Debug.Log($"{gameObject.name} clicked — Next Track ? {_outs[_nextTrackIdx]}");
    }

    private IEnumerator FlagAppearance(float waitSecond)
    {
        greenFlag.SetActive(true);
        redFlag.SetActive(false);
        
        yield return new WaitForSeconds(waitSecond);
        OnClicked();
    }
}
