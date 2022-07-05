using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class Calculate : MonoBehaviour {

    [SerializeField] private InputField _firstInputField;
    [SerializeField] private InputField _secondInputField;

    [SerializeField] private Text _answerText;

    private float answer;
    private float firstConvertInputFiel;
    private float secondConvertInputFiel;

    public void Restart() {
        _firstInputField.text = "";
        _secondInputField.text = "";
        _answerText.text = "";
    }

    public void onClickPlusButton() {
        convertInputField();
        answer = firstConvertInputFiel + secondConvertInputFiel;

        _answerText.text = answer.ToString();
    }

    public void onClickMinusButton() {
        convertInputField();
        answer = firstConvertInputFiel - secondConvertInputFiel;

        _answerText.text = answer.ToString();
    }

    public void onClickMultiplyButton() {
        convertInputField();
        answer = firstConvertInputFiel * secondConvertInputFiel;

        _answerText.text = answer.ToString();
    }

    public void onClickDivideButton() {
        convertInputField();

        if (firstConvertInputFiel == 0 || secondConvertInputFiel == 0) {
            _answerText.text = "На 0 делить нельзя";

        } else {
            answer = firstConvertInputFiel + secondConvertInputFiel;
            _answerText.text = answer.ToString();
        }
    }

    private void convertInputField() {
        if (_firstInputField.text != "" && _secondInputField.text != "") {
            firstConvertInputFiel = Convert.ToInt32(_firstInputField.text);
            secondConvertInputFiel = Convert.ToInt32(_secondInputField.text);
        }
    }


}
