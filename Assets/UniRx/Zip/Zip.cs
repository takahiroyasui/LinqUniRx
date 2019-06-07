using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx;

public class Zip : MonoBehaviour
{
    void Start()
    {
        var list1 = new List<string> { "A", "B", "C", "D", "E" }.ToObservable();
        var list2 = new List<int> { 1, 2, 3, 4, 5 }.ToObservable();
        
        Observable
            .Zip(list1, list2, (a, b) => a + b)
            .Subscribe(x => Debug.Log(x));
    }
}
