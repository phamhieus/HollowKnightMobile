using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Switch : MonoBehaviour
{
    public Sprite triggered;
    public GameObject obstacle;
    public GameObject trap;

    private SpriteRenderer _spriteRenderer;

    void Start()
    {
        _spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
    }

    public void TurnOn()
    {
        _spriteRenderer.sprite = triggered;

        obstacle.GetComponent<Obstacle>().destroy();

        trap.GetComponent<Trap>().Trigger();

        gameObject.layer = LayerMask.NameToLayer("Decoration");
    }
}
