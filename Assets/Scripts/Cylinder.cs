using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Cylinder : Shape
{
    [SerializeField] private Text infoText;
    private void Start()
    {
        SetInfoFieldAndColor(infoText, "Green");
        ShowDiscription();
    }

    protected override string GetAdditionalInfo()
    {
        return "It looks like stick.";
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
