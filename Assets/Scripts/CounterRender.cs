using TMPro;
using UnityEngine;

public class CounterRender : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _number;
    [SerializeField] private Counter _counter;

    private void OnEnable()
    {
        _counter.NumberCounted += ShowText;
    }
    
    private void OnDisable()
    {
        _counter.NumberCounted -= ShowText;
    }

    private void ShowText(float numberOnCounter)
    {
        _number.text = "Counter: " + numberOnCounter;
    }
}
