using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx;
using System.Threading;

public class Concat : MonoBehaviour
{
    void Start()
    {
        var list1 = Observable.Create<string>(observer => {
            Thread.Sleep(1);
            observer.OnNext("A1");
            Thread.Sleep(8);
            observer.OnNext("A2");
            Thread.Sleep(2);
            observer.OnNext("A3");
            observer.OnCompleted();
            return Disposable.Empty;
        }).SubscribeOn(Scheduler.ThreadPool);

        var list2 = Observable.Create<string>(observer => {
            Thread.Sleep(3);
            observer.OnNext("B1");
            Thread.Sleep(1);
            observer.OnNext("B2");
            Thread.Sleep(12);
            observer.OnNext("B3");
            observer.OnCompleted();
            return Disposable.Empty;
        }).SubscribeOn(Scheduler.ThreadPool);

        Observable
            .Concat(list1, list2)
            .Subscribe(x => Debug.Log(x));
    }
}
