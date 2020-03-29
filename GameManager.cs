using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static int[,] ARR = new int[19, 14];
    public static int black_or_white = 1;
    public static int win = 0;
    public Transform hex;
    // Start is called before the first frame update
    void Start()
    {       
        for (int i = 0; i < ARR.GetLength(0); i++)
        {
            for (int j = 0; j < ARR.GetLength(1); j++)
            {
                ARR[i, j] = 0;
                if (j%2==0)
                {
                    Transform cell = Instantiate(hex, new Vector3(i * 2, j * 1.6f, 0), Quaternion.identity);
                    cell.GetComponent<hextile>().x = i;
                    cell.GetComponent<hextile>().y = j;
                }
                else
                {
                    Transform cell = Instantiate(hex, new Vector3(i * 2 -1, j * 1.6f, 0), Quaternion.identity);
                    cell.GetComponent<hextile>().x = i;
                    cell.GetComponent<hextile>().y = j;
                }

            }
        }
    }
    int check(int i, int j)
    {
        try
        {
            int xx = 0;
            for (int k = 0; k<5; k++)
            {
                xx = xx + ARR[i + k, j];
            }
            if (xx == ARR[i,j]*5)
            {
                return ARR[i, j];
            }
        }
        finally { }

        if ((i%2==0 && j%2==0)||(i%2!=0 && j%2==0))
        {
            try
            {
                int xx = 0;
                int[] arr = new int[] {0, 1, 1, 2, 2 };
                for (int k = 0; k < 5; k++)
                {
                    xx = xx + ARR[i + arr[k], j+k];
                }
                if (xx == ARR[i, j] * 5)
                {
                    return ARR[i, j];
                }
            }
            finally {}
            try
            {
                int xx = 0;
                int[] arr = new int[] { 0, 0, -1, -1, -2 };
                for (int k = 0; k < 5; k++)
                {
                    xx = xx + ARR[i + arr[k], j + k];
                }
                if (xx == ARR[i, j] * 5)
                {
                    return ARR[i, j];
                }
            }
            finally {}

        }
        else
        {
            try
            {
                int xx = 0;
                int[] arr = new int[] { 0, -1, -1, -2, -2 };
                for (int k = 0; k < 5; k++)
                {
                    xx = xx + ARR[i + arr[k], j + k];
                }
                if (xx == ARR[i, j] * 5)
                {
                    return ARR[i, j];
                }
            }
            finally { }
            try
            {
                int xx = 0;
                int[] arr = new int[] { 0, 0, 1, 1, 2 };
                for (int k = 0; k < 5; k++)
                {
                    xx = xx + ARR[i + arr[k], j + k];
                }
                if (xx == ARR[i, j] * 5)
                {
                    return ARR[i, j];
                }
            }
            finally { }
        }
        return 0;
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonUp(0) && win ==0)
        {
            for (int i = 0; i < ARR.GetLength(0); i++)
            {
                for (int j = 0; j < ARR.GetLength(1); j++)
                {
                    if (ARR[i,j] != 0)
                    {
                        if (win ==0)
                        {
                            win = check(i, j);
                            if (win!=0)
                            {
                                Debug.Log(win);
                            }
                            
                        }
                    }
                }
            }
        }
    }
}
