using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class SettingsButton : MonoBehaviour
{
    private Canvas settingsUI;
    
    void Start()
    {
        settingsUI = GetComponentInChildren<Canvas>();
        SetPanelVisibility(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void TogglePanelVisibility() {
        foreach(Transform child in settingsUI.transform)
        {
            bool currVisibility = child.gameObject.activeSelf;
            child.gameObject.SetActive(!currVisibility);
        }
    }

    public void ShowPanel() {
        SetPanelVisibility(true);
    }

    public void HidePanel() {
        SetPanelVisibility(false);
    }

    private void SetPanelVisibility(bool isVisible) {
        foreach(Transform child in settingsUI.transform)
        {
            child.gameObject.SetActive(isVisible);
        }
    }
}
