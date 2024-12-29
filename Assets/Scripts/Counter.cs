using System;
using UnityEngine;

public class Counter : MonoBehaviour
{
    private float _number = 0;

    public float Number => _number;

    public void Increment()
    {
        _number++;
    }

}