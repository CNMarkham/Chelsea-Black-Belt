using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HueShifter : MonoBehaviour
{
    public Color[] colors;
    public float speed;

    private Renderer rend;
    private int rainbowPicker;
    private Color newColor;
    private float delay;
    private float colorTimer;
    // Start is called before the first frame update
    void Start()
    {
        rend = GetComponent<Renderer>();
        rainbowPicker = 0;
        newColor = rend.material.color;
        colorTimer = 0.5f;
    }

    // Update is called once per frame
    void Update()
    {
        newColor = Color.Lerp(colors[rainbowPicker], colors[rainbowPicker + 1], colorTimer);
        rend.material.SetColor("_OutlineColor", newColor);

        colorTimer += Time.deltaTime;
        if (colorTimer >= 1)
        {
            colorTimer = 0;
            rainbowPicker += 1;
        }
        if (rainbowPicker > 5)
        {
            rainbowPicker = 0;
        }

    }
}
