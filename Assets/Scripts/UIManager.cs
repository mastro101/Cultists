using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public Text counterText;
    public Counter counter;

    private void Awake()
    {
        counter = FindObjectOfType<Counter>();
    }

    private void Update()
    {
        counterText.text = "Cultisti" + counter.Cultisti.Length;
    }
}
