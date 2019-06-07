using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx;
using System;

public class Timer : MonoBehaviour
{
    void Start()
    {
        Debug.Log("Timer START");
        Observable.Timer(TimeSpan.FromSeconds(3))
            .Subscribe(_ => Debug.Log("OK"));
    }
}
