using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class win_sprite : MonoBehaviour
{
    public Sprite black;
    public Sprite white;
    private SpriteRenderer spriteRenderer;
    // Start is called before the first frame update
    void Start()
    {
        spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
        spriteRenderer.enabled = false;
    }

    // Update is called once per frame

    void Update()
    {    
        if (GameManager.win == 7)
        {
            spriteRenderer.sprite = white;
            spriteRenderer.enabled = true;
        }
        if (GameManager.win == 13)
        {
            spriteRenderer.sprite = black;
            spriteRenderer.enabled = true;
        }
        if (GameManager.win == 0)
        {
            spriteRenderer.enabled = false;
        }
    }
}
