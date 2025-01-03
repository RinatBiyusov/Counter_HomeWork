using System;
using System.Collections;
using UnityEngine;

public class Counter : MonoBehaviour
{
    private readonly WaitForSeconds _waitTime = new(0.5f);
    private float _number = 0;
    private bool _isCounting = true;
    private Coroutine _coroutine;

    public event Action<float> NumberCounted;

    private void OnMouseDown()
    {
        Debug.Log("Произошел клик.");

        if (_isCounting)
        {
            _coroutine = StartCoroutine(Increment());
            _isCounting = false;
        }
        else
        {
            StopCoroutine(_coroutine);
            _isCounting = true;
        }
    }

    private IEnumerator Increment()
    {
        while (true)
        {
            _number++;
            NumberCounted?.Invoke(_number);
            yield return _waitTime;
        }
    }
}