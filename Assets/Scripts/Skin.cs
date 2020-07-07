using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.Assertions;
using System;

public class Skin : MonoBehaviour
{
    public int skinIndex;
    private Image skinImage;
    private TextMeshProUGUI Stars;

    void Awake()
    {
        Stars= GameObject.FindGameObjectWithTag("Stars").GetComponent<TextMeshProUGUI>();
    }

    public void UnlockSkin()
    {
        var starCount = Convert.ToInt32(Stars.text);
        if (starCount >= 50)
        {
            var LockOverlay = transform.GetChild(1).gameObject;
            LockOverlay.SetActive(false);
            starCount = starCount - 50;
            Stars.text =starCount.ToString();
        }
    }

    public void SkinChange()
    {
        skinImage = transform.GetChild(0).GetComponent<Image>();
        FindObjectOfType<GameManager>().SetSkin(skinImage);
    }
}
