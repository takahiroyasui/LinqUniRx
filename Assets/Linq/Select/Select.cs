using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class Select : MonoBehaviour
{
    void Start()
    {
        var list = new List<int> { 1, 2, 3, 4, 5 }.Select(x => x * x);

        Debug.Log(string.Join(", ", list));
        // { 1, 4, 9, 16, 25}
    }
}
