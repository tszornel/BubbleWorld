using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Spawns bubbles from the bottom of the screen with random letters.
/// </summary>
public class BubbleSpawner : MonoBehaviour
{
    public Bubble bubblePrefab;
    public float spawnInterval = 1f;
    public Vector2 spawnArea = new Vector2(8f, 1f); // width x height at bottom
    public Vector2 bubbleSizeRange = new Vector2(0.5f, 1.5f);

    private float timeSinceLastSpawn;

    private readonly List<char> letterPool = new List<char>();

    void Start()
    {
        PrepareLetterPool();
    }

    void Update()
    {
        timeSinceLastSpawn += Time.deltaTime;
        if (timeSinceLastSpawn >= spawnInterval)
        {
            SpawnBubble();
            timeSinceLastSpawn = 0f;
        }
    }

    private void PrepareLetterPool()
    {
        // Vowels are added multiple times to increase their frequency
        string vowels = "AEIOUY";
        foreach (char c in vowels)
        {
            for (int i = 0; i < 5; i++)
                letterPool.Add(c);
        }
        // Consonants
        string consonants = "BCDFGHJKLMNPQRSTVWXZ";
        foreach (char c in consonants)
        {
            letterPool.Add(c);
        }
    }

    private void SpawnBubble()
    {
        Vector3 pos = transform.position + new Vector3(
            Random.Range(-spawnArea.x / 2f, spawnArea.x / 2f),
            Random.Range(-spawnArea.y / 2f, spawnArea.y / 2f),
            0f);
        Bubble bubble = Instantiate(bubblePrefab, pos, Quaternion.identity, transform);
        char letter = letterPool[Random.Range(0, letterPool.Count)];
        float size = Random.Range(bubbleSizeRange.x, bubbleSizeRange.y);
        bubble.Initialize(letter, size);
    }
}
