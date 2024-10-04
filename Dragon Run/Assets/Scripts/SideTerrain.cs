using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SideTerrain : MonoBehaviour
{
    public const int length = 100;

    int[] heightmap = new int[length];
    GameObject[] heightGO = new GameObject[length];

    void Start()
    {
        for (int i = 0; i <length; i++)
        {
            heightmap[i] = Random.Range(1, length);
            
            GameObject gameObject = GameObject.CreatePrimitive(PrimitiveType.Cube);
            heightGO[i] = gameObject;

            TransformGO(i);
        }

        Camera.main.transform.position = new Vector3(length / 2, length / 2, -length);
    }

    void TransformGO(int i)
    {
        GameObject gameObject = heightGO[i];
        gameObject.transform.localScale = new Vector3(1, heightmap[i], 1);
        gameObject.transform.localPosition = new Vector3(i, heightmap[i] / 2f, 0);
        gameObject.name = "column " + i +" (height=" + heightmap[i] + ")";
    }
}
