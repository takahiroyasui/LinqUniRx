using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx;

public class Take : MonoBehaviour
{
    void Start()
    {
        var list = new List<int> { 1, 2, 3, 4, 5 };

        list.ToObservable()
            .Take(3)
            .Subscribe(x => Debug.Log(x));
    }
}
