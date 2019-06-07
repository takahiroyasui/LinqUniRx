using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx;

public class Concat : MonoBehaviour
{
    void Start()
    {
        var list1 = new List<string> { "A1", "A2", "A3", "A4", "A5" }.ToObservable();
        var list2 = new List<string> { "B1", "B2", "B3", "B4", "B5" }.ToObservable();

        Observable
            .Concat(list1, list2)
            .Subscribe(x => Debug.Log(x));
    }
}
