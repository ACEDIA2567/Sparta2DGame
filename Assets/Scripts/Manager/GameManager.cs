using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    [SerializeField] private Text playerName;
    [SerializeField] private Text nameGroup;
    [HideInInspector] public List<string> NPCNames;

    private void Awake()
    {
        if (Instance != null) return;

        Instance = this;
    }

    void Start()
    {
        
    }

    void Update()
    {
        NameView();
    }

    private void NameView()
    {
        nameGroup.text = playerName.text;
        for (int i = 0; i < NPCNames.Count; i++)
        {
            nameGroup.text += "\n" + NPCNames[i];
        }
    }
}
