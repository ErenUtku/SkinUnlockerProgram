using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;

public class GameManager : MonoBehaviour
{
    public GameObject skinPanel;
    public SpriteRenderer PlayerSkin;

    void Start()
    {
        
    }
    public void OpenSkinPanel()
    {
        skinPanel.SetActive(true);
    }
    public void CloseSkinPanel()
    {
        skinPanel.SetActive(false);
    }

    public void SetSkin(Image skin)
    {
        PlayerSkin.sprite = skin.sprite;
    }

    void Update()
    {
        
    }
}
