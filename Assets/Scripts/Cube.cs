using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Cube : Shape
{
    [SerializeField] private Text infoText;
    private void Start()
    {
        SetInfoFieldAndColor(infoText, "Red");
        ShowDiscription();
    }

    protected override string GetAdditionalInfo()
    {
        return "It has sharp ages.";
    }

    protected override string GetColor(string color)
    {
        return color;
    }

    protected override string GetTypeOfShape()
    {
        return name;
    }
}
