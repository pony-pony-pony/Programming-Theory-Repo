using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Sphere : Shape
{
    [SerializeField] private Text infoText;
    private void Start()
    {
        SetInfoFieldAndColor(infoText, "Black");
        ShowDiscription();
    }

    protected override string GetAdditionalInfo()
    {
        return "It's round.";
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
