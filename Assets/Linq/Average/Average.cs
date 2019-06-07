using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class Average : MonoBehaviour
{
    void Start()
    {
        double average = new List<int> { 0, 1, 2, 3 }.Average();

        Debug.Log(average);// 1.5
    }
}
