using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Modal : MonoBehaviour
{
    [SerializeField]
    private Button toggleButton = default;

    [SerializeField]
    private Button showButton = default;

    [SerializeField]
    private Button hideButton = default;

    [SerializeField]
    private GameObject modal = default;
    
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

        if(showButton != null)
        {
            showButton.onClick.AddListener(OnShowClick);
        }

        if(hideButton != null)
        {
            hideButton.onClick.AddListener(OnHideClick);
        }
    }

    private void OnClick() {
        bool currVisibility = modal.activeSelf;
        modal.SetActive(!currVisibility);
    }

    private void OnShowClick() {
        modal.SetActive(true);
    }

    private void OnHideClick() {
        modal.SetActive(false);
    }
}
