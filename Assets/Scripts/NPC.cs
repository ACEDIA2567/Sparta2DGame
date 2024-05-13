using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class NPC : MonoBehaviour
{
    [SerializeField] private string name;
    [SerializeField] private GameObject panel;
    [SerializeField] private Text nameText;
    private Camera camera;
    private Vector3 distance;

    void Start()
    {
        camera = Camera.main;
        distance = new Vector3(0, 0.8f, 0);
        Vector2 textpos = transform.position + distance;
        panel.transform.position = camera.WorldToScreenPoint(textpos);

        // NPC 이름 UI에 출력
        nameText.text = name;
        // NPC 이름 정보 게임매니저에 추가
        GameManager.Instance.NPCNames.Add(name);
    }
}
