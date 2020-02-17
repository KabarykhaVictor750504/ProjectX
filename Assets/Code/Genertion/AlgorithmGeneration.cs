using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class AlgorithmGeneration : MonoBehaviour
{

    private int[,] map;

    private int x;

    private int startIndex;

    private int endIndex;

    private int y;


    public AlgorithmGeneration()
    {
        x = Random.Range(4, 9);
        y = Random.Range(6, 15);
        map = new int[x, y];
    }

    public void SetPath()
    {
        startIndex = Random.Range(0, x-1);
        endIndex = startIndex;
        for(int i = 0; i < y; ++i)
        {
            map[startIndex, i] = 1;
        }
    }
}
