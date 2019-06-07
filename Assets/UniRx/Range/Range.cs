using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx;

public class Range : MonoBehaviour
{
    void Start()
    {
        Observable
            .Range(1, 5)
            .Subscribe(x => Debug.Log(x));
    }
}
