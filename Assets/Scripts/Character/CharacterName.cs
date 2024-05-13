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
        // InputField�� OnEndEdit�� ������ �� �� �ش� �޼��� ����ǰ� ��
        nameInputField.onEndEdit.AddListener(NameLengthCheck);
    }

    // �Է��� ���� ���� ���� ��ư Ȱ��ȭ ���θ� ����
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
