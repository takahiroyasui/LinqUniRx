using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx;
using System;

public class Interval : MonoBehaviour
{
    void Start()
    {
        Observable
            .Interval(TimeSpan.FromSeconds(1))
            .Subscribe(x => Debug.Log(x));
    }
}
