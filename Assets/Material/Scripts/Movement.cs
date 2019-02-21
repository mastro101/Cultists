using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour {

    public float Speed;

    Transform target;

    private void Start()
    {
        target = FindObjectOfType<MovePoint>().transform;
    }

    private void Update()
    {

        transform.LookAt(target);
        float step = Speed * Time.deltaTime;
        transform.position = Vector3.MoveTowards(transform.position, target.position, step);
        
    }
}
