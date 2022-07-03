using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class TwoNumbersComparer : MonoBehaviour {

    [SerializeField] private InputField _ferstInput;
    [SerializeField] private InputField _secondInput;

    [SerializeField] private Text _resultText;

    public void Restart() {
        _ferstInput.text = "";
        _secondInput.text = "";
        _resultText.text = "";
    }

    public void ComparerNumbers() {
        int ferstNumber = Convert.ToInt32(_ferstInput.text);
        int secondNumber = Convert.ToInt32(_secondInput.text);

        if(ferstNumber < secondNumber) {
            _resultText.text = "<";

        } else if (ferstNumber > secondNumber) {
            _resultText.text = ">";

        } else if (ferstNumber == secondNumber) {
            _resultText.text = "=";

        } else {
            _resultText.text = "что-то не так";
        }
    }
}
