﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BarScript : MonoBehaviour
{

    public Image bar;
    public float m_coolDown = 15.0f;
    public float counter;


    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
                counter += Time.deltaTime;
                if (counter <= m_coolDown)
                {
                        
                        bar.fillAmount = counter / m_coolDown;
                }
                else
                {

                }
    }
}
