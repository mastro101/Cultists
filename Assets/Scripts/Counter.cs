using UnityEngine;
using System.Collections;

public class Counter : MonoBehaviour
{

    public GameObject[] Cultisti;
    

    private void Update()
    {
        Cultisti = GameObject.FindGameObjectsWithTag("Player");
    }
}
