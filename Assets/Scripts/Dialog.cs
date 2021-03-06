﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Dialog : MonoBehaviour
{
    public TextMeshProUGUI textDisplay;
    public string[] sentences;
    private int index;
    private int indx;
    public float typingSpeed;

    public GameObject continueButton;
    public GameObject Image;
    public GameObject camera;

    void Start()
    {
        StartCoroutine(Type());
        camera.SetActive(false);
    }

    void Update()
    {
        if(textDisplay.text == sentences[index])
        {
            continueButton.SetActive(true);
        }
    }

    IEnumerator Type()
    {
        foreach(char letter in sentences[index].ToCharArray())
        {
            textDisplay.text += letter;
            yield return new WaitForSeconds(typingSpeed);
        }
    }

    int plus = 0;
	public void AddI()
    {
		plus++;
		if(plus>5)
        {
			Destroy(Image);
            camera.SetActive(true);
		}
	}

    public void NextSentence()
    {
        continueButton.SetActive(false);

        if(index < sentences.Length-1)
        {
            index++;
            textDisplay.text = "";
            StartCoroutine(Type());
        }
        else
        {
            textDisplay.text = "";
            continueButton.SetActive(false);
        }
    }
}
