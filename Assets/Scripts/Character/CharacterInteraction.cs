using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterInteraction : MonoBehaviour
{
    // ��ȣ�ۿ� ������ �� ���̴� Ű
    [SerializeField] private GameObject interaction;

    private Controller controller;
    private GameObject dialog = null;

    void Start()
    {
        controller = GetComponent<Controller>();
        controller.OnTalk += NPCTalk;
    }
 
    // ��ȣ�ۿ� Ű�� Ȱ��ȭ�� ���� ��ȭâ Ȱ��ȭ
    private void NPCTalk()
    {
        if (interaction.activeSelf)
        {
            dialog?.SetActive(true);
        }
    }

    // NPC�� ��������� �� ��ȣ�ۿ� Ű Ȱ��ȭ
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Npc"))
        {
            interaction.SetActive(true);
            dialog = collision.GetComponent<NPC>()?.dialog;
        }
    }

    // NPC�� �־����� �� ��ȣ�ۿ� Ű ��Ȱ��ȭ
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Npc"))
        {
            interaction.SetActive(false);
        }
    }
}
