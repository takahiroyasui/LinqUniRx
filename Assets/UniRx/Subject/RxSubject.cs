using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx;

public class RxSubject : MonoBehaviour
{
    void Start()
    {
        var subject = new Subject<int>();
        subject.Subscribe(x => Debug.Log(x));

        subject.OnNext(1);
        subject.OnNext(2);
        subject.OnNext(3);
    }
}
