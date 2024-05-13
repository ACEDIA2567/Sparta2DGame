using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class CharacterName : MonoBehaviour
{
    [SerializeField] private Text characterName;
    [SerializeField] private TMP_InputField nameInputField;
    [SerializeField] private Button joinButton;

    void Start()
    {
        nameInputField.onEndEdit.AddListener(NameLengthCheck);
    }

    public void NameLengthCheck(string name)
    {
        if (name.Length > 1 && name.Length <= 10)
        {
            characterName.text = name;
            joinButton.interactable = true;
        }
        else
        {
            joinButton.interactable = false;
        }
    }
}
