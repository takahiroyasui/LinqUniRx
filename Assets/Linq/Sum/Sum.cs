using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class Sum : MonoBehaviour
{
    void Start()
    {
        int sum = new List<int> { 1, 2, 3, 4, 5 }.Sum();

        Debug.Log(sum);// 15
    }
}
