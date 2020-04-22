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
            SetColor(defaultColor);
        }
    }

    public void SetColor(Color color) {
        if(image == null)
        {
            return;
        }

        image.color = color;
    }

    public void SetImage(Sprite sprite) {
        if(image == null)
        {
            return;
        }
        
        image.sprite = sprite;
    }
}
