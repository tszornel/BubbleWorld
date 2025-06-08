using UnityEngine;

/// <summary>
/// Controls a single bubble including movement and collisions.
/// Attach this to a prefab that has a Rigidbody2D and CircleCollider2D.
/// </summary>
[RequireComponent(typeof(Rigidbody2D))]
[RequireComponent(typeof(CircleCollider2D))]
public class Bubble : MonoBehaviour
{
    public char Letter { get; private set; }
    private Rigidbody2D rb;

    // Force applied upwards which increases over time
    private float baseUpwardForce = 1f;

    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.gravityScale = 0f; // No gravity in this game
    }

    /// <summary>
    /// Sets the displayed letter on the bubble and the bubble size.
    /// </summary>
    public void Initialize(char letter, float size)
    {
        Letter = letter;
        transform.localScale = new Vector3(size, size, 1f);
        // Display the letter on a child Text or TextMesh
        var text = GetComponentInChildren<TMPro.TextMeshProUGUI>();
        if (text != null)
            text.text = Letter.ToString();
    }

    void FixedUpdate()
    {
        // Apply upward force that increases as the game runs
        float speedMultiplier = 1f + Time.timeSinceLevelLoad * 0.1f;
        rb.AddForce(Vector2.up * baseUpwardForce * speedMultiplier);
    }
}
