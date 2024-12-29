using System.Collections;
using TMPro;
using UnityEngine;

public class Incrementor : MonoBehaviour
{
    [SerializeField] private float _smoothDecreaseDuration = 0.5f;
    [SerializeField] private TextMeshProUGUI _counterText;
    [SerializeField] private Counter _counter;

    private bool _isCounting = false;

    private void Start()
    {
        _counterText.text = _counter.Number.ToString("");
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (_isCounting)
            {
                StopCounter();
                _isCounting = false;
            }
            else
            {
                StartCounter();
                _isCounting = true;
            }
        }
    }

    private void StartCounter()
    {
        StartCoroutine(IncreaseNumberCounter());
    }

    private void StopCounter()
    {
        StopAllCoroutines();
    }

    private IEnumerator IncreaseNumberCounter()
    {
        while (true)
        {
            _counter.Increment();

            _counterText.text = _counter.Number.ToString("");

            yield return new WaitForSeconds(_smoothDecreaseDuration);
        }
    }
}