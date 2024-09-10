using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DebugExample : MonoBehaviour
{
    private List<int> _numbers;

    private int _coin;
    private List<float> _floatNumbers = new();

    private void Start()
    {
        DebugClass debugClass = new DebugClass();
        debugClass.Add(0);

        _numbers.Add(0);
    }
}
