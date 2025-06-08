using System.Collections.Generic;
using UnityEngine;
using TMPro;

/// <summary>
/// Chooses a target word from a list and displays it above the play area.
/// </summary>
public class WordManager : MonoBehaviour
{
    public TextMeshProUGUI wordDisplay;
    public List<string> wordList;
    [HideInInspector]
    public string CurrentWord { get; private set; }

    void Start()
    {
        if (wordList != null && wordList.Count > 0)
        {
            CurrentWord = wordList[Random.Range(0, wordList.Count)].ToUpperInvariant();
            if (wordDisplay != null)
                wordDisplay.text = CurrentWord;
        }
    }
}
