﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FillStatusBar : MonoBehaviour {

    public Image fillImage;
    private Slider slider;
    public RandoController rando;
    // Start is called before the first frame update
    void Awake()
    {
        slider = GetComponent<Slider>();
    }

    // Update is called once per frame
    void Update()
    {
        if (slider.value <= slider.minValue) {
            fillImage.enabled = false;
        }
        if (slider.value > slider.minValue && !(fillImage)) {
            fillImage.enabled = true;
        }
        float fillValue = rando.friendRatio / 100;
        Debug.Log(fillValue);
        slider.value = fillValue;
    }
}
