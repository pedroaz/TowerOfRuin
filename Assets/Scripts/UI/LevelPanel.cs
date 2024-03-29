﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class LevelPanel : MonoBehaviour
{
    public GameObject panel;
    public TextMeshProUGUI text;


    private void Awake()
    {

    }

    public void ShowPanel(int level)
    {
        if(level == 1) {
            text.text = "Defend the Castle!";
        }
        else {

            text.text = "Wave: " + level.ToString();
        }
        StartCoroutine(Disapear());   
    }

    private IEnumerator Disapear()
    {
        panel.SetActive(true);

        yield return new WaitForSeconds(2);

        panel.SetActive(false);
    }
}
