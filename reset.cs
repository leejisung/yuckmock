using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class reset : MonoBehaviour
{
    // Start is called before the first frame update
    public void reset_arr()
    {
        for (int i = 0; i < GameManager.ARR.GetLength(0); i++)
        {
            for (int j = 0; j < GameManager.ARR.GetLength(1); j++)
            {
                GameManager.ARR[i, j] = 0;
                GameManager.win = 0;
            }
        }
    }
}
