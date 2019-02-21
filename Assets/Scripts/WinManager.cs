using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class WinManager : MonoBehaviour
{

    Counter counter;

    public Text WinText;
    public Text LoseText;
    public bool Win;


    private void Start()
    {
        counter = FindObjectOfType<Counter>();
    }

    private void Update()
    {
        if (counter.Cultisti.Length <= 1)
        {
            LoseText.gameObject.SetActive(true);
        }
        else
        {
            LoseText.gameObject.SetActive(false);
        }

        if (Win == true)
        {
            WinText.gameObject.SetActive(true);
        }
        else
        {
            WinText.gameObject.SetActive(false);
        }
    }
}
