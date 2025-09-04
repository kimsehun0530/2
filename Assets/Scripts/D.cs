using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class D : MonoBehaviour
{
    // Start is called before the first frame update
    MeshRenderer render;
    Rigidbody rb;
    [SerializeField]float timeTowait = 5f;
    void Start()
    {
        render = GetComponent<MeshRenderer>();
        rb = GetComponent<Rigidbody>();

        render.enabled = true;
        rb.useGravity = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.timeSinceLevelLoad >= timeTowait)
        {
            render.enabled = true;
            rb.useGravity = true;
            enabled = false;
        }
    }
}
