using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Modal : MonoBehaviour
{
    [SerializeField]
    private Button toggleButton;

    [SerializeField]
    private GameObject modal;
    
    void Start()
    {
        if(modal == null)
        {
            return;
        }

        modal.SetActive(false);
        
        if(toggleButton != null)
        {
            toggleButton.onClick.AddListener(OnClick);
        }
    }

    private void OnClick() {
        bool currVisibility = modal.activeSelf;
        modal.SetActive(!currVisibility);
    }
}
