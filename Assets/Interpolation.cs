using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interpolation
{
    public static Vector2 Lerp(List<Vector2> list, float t)
    {

        float range = 1f / (list.Count - 1);
        int index = Mathf.FloorToInt(t / range);
        return Vector3.Lerp(list[index], list[index + 1], Mathf.InverseLerp(range * index, range * (index + 1), t));
    }
}