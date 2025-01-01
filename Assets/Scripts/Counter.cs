using System.Collections;
using UnityEngine;

public class Counter : MonoBehaviour
{
    private readonly float _smoothDecreaseDuration = 0.5f;
    private float _number = 0;
    private bool _isCounting = false;

    public float Number => _number;

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            _isCounting = !_isCounting;

            if (_isCounting)
            {
                StartCoroutine(nameof(Enumerator));

            }
            else
            {
                StopCoroutine(nameof(Enumerator));
            }
        }
    }

    private IEnumerator Enumerator()
    {
        while (true)
        {
            _number++;

            yield return new WaitForSeconds(_smoothDecreaseDuration);
        }
    }
}