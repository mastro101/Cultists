using UnityEngine;
using System.Collections;

public class MovePoint : MonoBehaviour
{
    Transform Director;
    Counter counter;
    WinManager winManager;

    int playerInside;

    private void Start()
    {
        Director = GetComponent<Transform>();
        counter = FindObjectOfType<Counter>();
        winManager = FindObjectOfType<WinManager>();
    }

    private void Update()
    {
        if(Input.GetMouseButtonDown(1))
        {           
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out hit) && hit.transform.name == "Plane")
            {
                Director.position = hit.point + new Vector3(0, +0.5f, 0);
            }
        }
        if (playerInside == counter.Cultisti.Length && counter.Cultisti.Length > 1)
            winManager.Win = true;
        else if (playerInside < counter.Cultisti.Length)
            winManager.Win = false;
    }

    void OnTriggerEnter(Collider other)
    {
        
        if (other.gameObject.tag == "Player")
        {
            playerInside++;
            
        }

    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            playerInside--;
        }
    }
}
