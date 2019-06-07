using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class Max : MonoBehaviour
{
    void Start()
    {
        int max = new List<int> { 5, 9, 15, 3, 21, 8, 11 }.Max();

        Debug.Log(max);// 21
    }
}
