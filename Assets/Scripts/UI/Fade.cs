﻿using UnityEngine;
using UnityEngine.UI;

public class Fade : MonoBehaviour {

    public float fadeInTime;
    private Image fadePanel;
    private Color currentColor = Color.black;

    void Start () {
        fadePanel = GetComponent<Image>();
	}
	
	void Update () {
		if(Time.timeSinceLevelLoad < fadeInTime)
        {
            //Fade in
            float alphaChange = Time.deltaTime / fadeInTime;
            currentColor.a -= alphaChange;
            fadePanel.color = currentColor;
        }
        else
        {
            gameObject.SetActive(false);
        }
	}
}