using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class Min : MonoBehaviour
{
    void Start()
    {
        int min = new List<int> { 21, 9, 15, 3, 8, 11 }.Min();

        Debug.Log(min);// 3
    }
}
