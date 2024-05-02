using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ColorPalete : MonoBehaviour
{
    public Slider redSlider;
    public Slider greenSlider;
    public Slider blueSlider;

    public Text redText;
    public Text greenText;
    public Text blueText;

    float red;
    float green;
    float blue;
    public Image previewImage;
    public Toggle toggleBool;

    BrushControls brushControls;
    public bool useCustomColor;


    private void Awake()
    {
        brushControls = GameObject.FindGameObjectWithTag("Player").GetComponentInChildren<BrushControls>();
        brushControls.colorPalete = this;
    }
    private void Update()
    {
        useCustomColor = toggleBool.isOn;
        updateText();
        updateImage();
        if (useCustomColor)
        {
            brushControls.r = redSlider.value;
            brushControls.g = greenSlider.value;
            brushControls.b = blueSlider.value;
            brushControls.locatorRenderLink.material.color = new Color(redSlider.value / 255, greenSlider.value / 255, blueSlider.value / 255);
        }
    }
    void updateText()
    {
        redText.text = redSlider.value.ToString();
        greenText.text = greenSlider.value.ToString();
        blueText.text = blueSlider.value.ToString();
    }
    void updateImage()
    {
        previewImage.color=  new Color(redSlider.value/255,greenSlider.value / 255, blueSlider.value / 255);
    }

}
