using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx;

public class Scan : MonoBehaviour
{
    void Start()
    {
        var list = new List<int> { 1, 2, 3, 4, 5 };

        list.ToObservable()
            .Scan((a, b) => a + b)
            .Subscribe(x => Debug.Log(x));
        // 1, 3, 6, 10, 15
    }
}
