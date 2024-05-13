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
        // InputField의 OnEndEdit가 실행이 될 때 해당 메서드 실행되게 함
        nameInputField.onEndEdit.AddListener(NameLengthCheck);
    }

    // 입력한 글자 수에 따라서 버튼 활성화 여부를 정함
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
