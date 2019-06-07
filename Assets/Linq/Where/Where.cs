using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class Where : MonoBehaviour
{
    void Start()
    {
        var list = new List<int> { 1, 2, 3, 4, 5 }.Where(x => x > 2);

        Debug.Log(string.Join(", ", list));// { 3, 4, 5 }
    }
}
