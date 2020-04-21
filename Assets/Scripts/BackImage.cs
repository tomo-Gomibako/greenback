using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BackImage : MonoBehaviour
{
    private Image image = default;

    void Start()
    {
        image = GetComponent<Image>();

        Color defaultColor = Color.white;
        defaultColor.a = 0;
        image.color = defaultColor;
    }

    public void SetColor(Color color) {
        image.color = color;
    }

    public void SetImage(Sprite sprite) {
        image.sprite = sprite;
    }
}
