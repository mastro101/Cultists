using UnityEngine;
using System.Collections;

public class Trap : MonoBehaviour
{

    private void OnTriggerEnter (Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            Destroy(other.gameObject);
        }
    }

    
}
