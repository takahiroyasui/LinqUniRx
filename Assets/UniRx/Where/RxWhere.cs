using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx;

public class RxWhere : MonoBehaviour
{
    void Start()
    {
        var list = new List<int> { 1, 2, 3, 4, 5 };

        list.ToObservable()
            .Where(x => x > 2)
            .Subscribe(x => {
                Debug.Log(x);
            });
    }
}
