using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hextile : MonoBehaviour
{
    public int x;
    public int y;
    SpriteRenderer render;
    // Start is called before the first frame update
    void Start()
    {
        render = GetComponent<SpriteRenderer>();
    }
    void OnMouseUp()
    {
        if (GameManager.ARR[x, y] == 0)
        {
            if (GameManager.black_or_white == 1)
            {
                GameManager.ARR[x, y] = 1;
                GameManager.black_or_white = 2;
            }
            else if (GameManager.black_or_white == 2)
            {
                GameManager.ARR[x, y] = 2;
                GameManager.black_or_white = 1;
            }

        }
    }
    // Update is called once per frame
    void Update()
    {
        if (GameManager.ARR[x, y] == 1)
        {
            render.color = new Color(255,255,255,255);
        }
        if (GameManager.ARR[x, y] == 2)
        {
            render.color = new Color(0, 0, 0, 255);
        }
    }
}
