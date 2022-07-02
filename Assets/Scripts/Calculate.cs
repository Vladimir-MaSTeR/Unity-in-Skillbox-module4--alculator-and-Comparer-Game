using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class Calculate : MonoBehaviour {

    [SerializeField] private InputField _firstInputField;
    [SerializeField] private InputField _secondInputField;

    [SerializeField] private Text _answerText;

    private int answer;

    public void onClickCalculate(Text text) {

        if (text.text.Equals("+") && _firstInputField.text != "" && _secondInputField.text != "") {
            answer = Convert.ToInt32(_firstInputField.text) + Convert.ToInt32(_secondInputField.text);
            _answerText.text = answer.ToString();

        } else if (text.text.Equals("-") && _firstInputField.text != "" && _secondInputField.text != "") {
            answer = Convert.ToInt32(_firstInputField.text) - Convert.ToInt32(_secondInputField.text);
            _answerText.text = answer.ToString();

        } else if (text.text.Equals("*") && _firstInputField.text != "" && _secondInputField.text != "") {
            answer = Convert.ToInt32(_firstInputField.text) * Convert.ToInt32(_secondInputField.text);
            _answerText.text = answer.ToString();

        } else if (text.text.Equals("/") && _firstInputField.text != "" && _secondInputField.text != "") {
            if(_firstInputField.text.Equals("0") || _secondInputField.text.Equals("0")) {
                _answerText.text = "На 0 делить нельзя";

            } else {
                answer = Convert.ToInt32(_firstInputField.text) / Convert.ToInt32(_secondInputField.text);
                _answerText.text = answer.ToString();
            }
        } 
        
    }
}
