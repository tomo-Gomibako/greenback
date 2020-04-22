using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BackImage : MonoBehaviour
{
    [SerializeField]
    private Color defaultColor = default;
    private Image image = default;

    void Start()
    {
        image = GetComponent<Image>();

        if(defaultColor != null) {
            defaultColor = Color.black;
            defaultColor.a = 0;
            image.color = defaultColor;
        }
    }

    public void SetColor(Color color) {
        image.color = color;
    }

    public void SetImage(Sprite sprite) {
        image.sprite = sprite;
    }
}
