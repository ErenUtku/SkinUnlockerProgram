using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class AnimatedBack : MonoBehaviour
{
    public Sprite[] animated;
    public Image animateimage;

    private void Update()
    {
        animateimage.sprite = animated[(int)(Time.time * 10) % animated.Length];
    }
}
