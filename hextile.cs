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
                GameManager.ARR[x, y] = 7;
                GameManager.black_or_white = 2;
            }
            else if (GameManager.black_or_white == 2)
            {
                GameManager.ARR[x, y] = 13;
                GameManager.black_or_white = 1;
            }

        }
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonUp(0))
        {
            if (GameManager.ARR[x, y] == 7)
            {
                render.color = new Color(255, 255, 255, 255);
            }
            else if (GameManager.ARR[x, y] == 13)
            {
                render.color = new Color(0, 0, 0, 255);
            }
            else if (GameManager.ARR[x, y] == 0)
            {
                render.color = new Color(150 / 255f, 150 / 255f, 150 / 255f, 255 / 255f);
            }
        }

    }
}
