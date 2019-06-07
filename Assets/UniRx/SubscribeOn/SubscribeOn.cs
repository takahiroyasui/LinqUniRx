using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx;
using UnityEngine.UI;
using System.Threading;

public class SubscribeOn : MonoBehaviour
{
    [SerializeField] Button button1 = default;
    [SerializeField] Button button2 = default;

    void onClick1()
    {
        var observable = Observable.Create<string>(observer => {
            Thread.Sleep(3000);
            observer.OnNext("OnClick button 1");
            observer.OnCompleted();
            return Disposable.Empty;
        });

        observable.Subscribe(x => Debug.Log(x));
    }

    void onClick2()
    {
        var observable = Observable.Create<string>(observer => {
            Thread.Sleep(3000);
            observer.OnNext("OnClick button 2");
            observer.OnCompleted();
            return Disposable.Empty;
        }).SubscribeOn(UniRx.Scheduler.ThreadPool);

        observable.Subscribe(x => Debug.Log(x));
    }

    void Start()
    {
        button1.OnClickAsObservable().Subscribe(_ => onClick1());
        button2.OnClickAsObservable().Subscribe(_ => onClick2());
    }
}
