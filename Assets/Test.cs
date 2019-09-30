using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[ExecuteInEditMode]
public class Test : MonoBehaviour
{
    [SerializeField] private RawImage rawImage;
    [SerializeField] private List<Vector2> horizontal;

    private void Update()
    {
        Texture2D texture2D = new Texture2D(1920, 1080);

        for (int i = 0; i < 1920; i++)
        {
            for (int k = 0; k < 1080; k++)
            {
                texture2D.SetPixel(i, k, Color.white);
            }
        }

        for (int i = 0; i < 1920; i++)
        {
            var pos = Interpolation.Lerp(horizontal, i / 1920f);
            texture2D.SetPixel((int)pos.x, (int)pos.y, Color.black);
            texture2D.SetPixel((int)pos.x, (int)pos.y + 1, Color.black);
            texture2D.SetPixel((int)pos.x + 1, (int)pos.y, Color.black);
            texture2D.SetPixel((int)pos.x + 1, (int)pos.y + 1, Color.black);
            //Debug.Log(pos + $"{i / 1920f}");
        }
        texture2D.Apply();
        rawImage.texture = texture2D;
    }
}