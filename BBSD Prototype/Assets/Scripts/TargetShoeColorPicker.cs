using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TargetShoeColorPicker : MonoBehaviour
{
    public List<Color> avaiableColors;

    void Start()
    {
        Image imageCom = GetComponent<Image>();
        int r = Random.Range(0,avaiableColors.Count);
        imageCom.color = avaiableColors[r];
    }
}
