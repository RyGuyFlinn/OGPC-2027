using UnityEngine;
using System;

public class BlinkingLight : MonoBehaviour
{
    public float blinkLength1;
    public float blinkLength2;
    public Color color1;
    public Color color2;
    private SpriteRenderer sprite;

    void Start()
    {
        sprite = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if ((DateTimeOffset.UtcNow.ToUnixTimeMilliseconds() / 1000.0) % (blinkLength1 + blinkLength2) < blinkLength1)
        {
            sprite.color = color1;
        }
        else
        {
            sprite.color = color2;
        }
    }
}
