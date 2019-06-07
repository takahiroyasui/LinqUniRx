using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class MethodChaining : MonoBehaviour
{
    void Start()
    {
        var list1 = new List<int> { 1, 2, 3, 4, 5 };
        var list2 = list1.Where(x => x > 2);
        var list3 = list1.Where(x => x > 2).Select(x => x * x);

        Debug.Log(string.Join(", ", list1));// { 1, 2, 3, 4, 5 }
        Debug.Log(string.Join(", ", list2));// { 3, 4, 5 }
        Debug.Log(string.Join(", ", list3));// { 9, 16, 25 }
    }
}
