using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class IMGUI : MonoBehaviour
{
    public Slider healthSlider;
    public Slider slider;
    private Rect healthPos;
    private Rect addPos;
    private Rect subPos;
    private float health = 0.0f;
    private float temp;
    // Use this for initialization
    void Start()
    {

        addPos = new Rect(0, 0, 50, 25);
        subPos = new Rect(50, 0, 50, 25);
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnGUI()
    {
        healthPos = new Rect(Screen.width / 2 - 50, 10, 100, 50);
        if (GUI.Button(addPos, "加血"))
        {
            temp = health + 0.1f > 1.0f ? 1.0f : health + 0.1f;
        }
        else if (GUI.Button(subPos, "减血"))
        {
            temp = health - 0.1f < 0 ? 0.0f : health - 0.1f;
        }
        health = Mathf.Lerp(health, temp, 0.05f);
        GUI.HorizontalScrollbar(healthPos, 0, health, 0, 1);
       slider.value = health;
        healthSlider.value = health;
    }
}
