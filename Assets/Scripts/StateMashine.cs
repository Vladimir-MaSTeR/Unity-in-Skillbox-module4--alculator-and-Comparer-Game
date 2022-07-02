using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StateMashine : MonoBehaviour {

    [SerializeField] private GameObject _ferstCanvas;
    [SerializeField] private GameObject _secondCanvas;
    [SerializeField] private GameObject _thirdCanvas;

    private GameObject _currentCanvas;

   
    // Start is called before the first frame update
    void Start() {
        _ferstCanvas.SetActive(true);
        _secondCanvas.SetActive(false);
        _thirdCanvas.SetActive(false);
        _currentCanvas = _ferstCanvas;
    }

    public void ChangeState(GameObject state) {
        if(_currentCanvas != null) {
            _currentCanvas.SetActive(false);
            state.SetActive(true);
            _currentCanvas = state;
        }
    }
}
