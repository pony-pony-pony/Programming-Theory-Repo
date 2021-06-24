using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public abstract class Shape : MonoBehaviour
{
    protected string currentColor { get; set; }
    protected Text infoField { get; set; }

    protected void SetInfoFieldAndColor(Text info, string color)
    {
        infoField = info;
        currentColor = color;
    }

    public void ShowDiscription()
    {
        infoField.text = GetTypeOfShape() + ": \n" +
            "Color - " + GetColor(currentColor) + "\n" +
            "About - " + GetAdditionalInfo();
    }

    protected abstract string GetTypeOfShape();

    protected abstract string GetColor(string color);

    protected abstract string GetAdditionalInfo();

    private void OnMouseEnter()
    {
        infoField.gameObject.SetActive(true);
    }
    private void OnMouseExit()
    {
        infoField.gameObject.SetActive(false);
    }

}
