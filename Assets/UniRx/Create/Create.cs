using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx;

public class Create : MonoBehaviour
{
    void Start()
    {
        var observable = Observable.Create<int>(observer => {
            observer.OnNext(1);
            observer.OnNext(2);
            observer.OnNext(3);
            observer.OnNext(4);
            observer.OnNext(5);
            observer.OnCompleted();
            return Disposable.Empty;
        });

        observable.Subscribe(x => Debug.Log(x));
    }
}
