using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx;

public class Distinct : MonoBehaviour
{
    void Start()
    {
        var list = new List<int> { 1, 2, 3, 3, 4, 5, 5 };

        list.ToObservable()
            .Distinct()
            .Subscribe(x => Debug.Log(x));
    }
}
