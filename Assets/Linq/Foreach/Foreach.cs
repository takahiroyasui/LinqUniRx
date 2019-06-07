using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Foreach : MonoBehaviour
{
    void Start()
    {
        var list = new List<int> { 1, 2, 3, 4, 5 };

        list.ForEach(x => Debug.Log(x * x));
        // { 1, 4, 9, 16, 25 }


        // list.ForEach(x => {
        //     Debug.Log("-----");
        //     Debug.Log(x * x);
        // });
    }
}
