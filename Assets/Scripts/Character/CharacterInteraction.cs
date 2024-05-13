using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterInteraction : MonoBehaviour
{
    // ��ȣ�ۿ� ������ �� ���̴� Ű
    [SerializeField] private GameObject interaction;
    private Controller controller;
    private GameObject dialog;

    void Start()
    {
        controller = GetComponent<Controller>();
        controller.OnTalk += NPCTalk;
    }
 
    private void NPCTalk()
    {
        if (interaction.activeSelf)
        {
            Debug.Log("������Ʈ�� Ȱ��ȭ �� ����");
            dialog.SetActive(true);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Npc"))
        {
            interaction.SetActive(true);
            dialog = collision.GetComponent<NPC>()?.dialog;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Npc"))
        {
            interaction.SetActive(false);
        }
    }
}
