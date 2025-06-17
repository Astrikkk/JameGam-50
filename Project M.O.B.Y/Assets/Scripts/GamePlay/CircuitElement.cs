using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CircuitElement : MonoBehaviour
{
    [SerializeField] private bool isBroken = false;
    [SerializeField] private Sprite FixedSprite;
    [SerializeField] private Sprite BrokenSprite;

    SpriteRenderer _spriteRenderer;
    private void Awake()
    {
        _spriteRenderer = GetComponent<SpriteRenderer>();
    }
    public void BreakElement()
    {
        isBroken = false;
    }

    public void Fix()
    {
        isBroken = false;
    }
}
