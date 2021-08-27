using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorSelectController : MonoBehaviour
{
    public Color selectedColor;

    public void UniverseRed()
    {
        selectedColor = Color.red;
    }
    public void RoyalBlue()
    {
        selectedColor = Color.blue;
    }
    public void TeamOrange()
    {
        selectedColor = new Color(1,0.25f,0);
    }
    public void Armadillo()
    {
        selectedColor = new Color(1, 1, 0);
    }
    public void White()
    {
        selectedColor = Color.white;
    }
    public void Black()
    {
        selectedColor = Color.black;
    }
    public void Grey()
    {
        selectedColor = Color.grey;
    }
    public void Green()
    {
        selectedColor = Color.green;
    }
    public void DarkGrey()
    {
        selectedColor = new Color(0.25f,0.25f,0.25f);
    }
}
