﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx;
using UnityEngine.UI;

public class ButtonEvent : MonoBehaviour
{
    [SerializeField] Button button;

    void Start()
    {
        button
            .OnClickAsObservable()
            .Subscribe(_ => Debug.Log("on click"));
    }
}
