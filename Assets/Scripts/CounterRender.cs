using TMPro;
using UnityEngine;

public class CounterRender : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _number;
    [SerializeField] private Counter _counter;

    private void Update()
    {
        if (_counter != null)
            _number.text = "Counter: " + _counter.Number.ToString();
    }
}
