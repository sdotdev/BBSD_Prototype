using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShoeColorChanger : MonoBehaviour
{
    public ColorSelectController csc;
    public Color onColor;

    void OnMouseDown()
    {
        Color toPutOn = csc.selectedColor;
        GetComponent<SpriteRenderer>().color = toPutOn;
    }
    void Update()
    {
        onColor = GetComponent<SpriteRenderer>().color;
    }
}
