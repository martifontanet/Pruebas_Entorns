using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandleMover : MonoBehaviour
{
    public float Amplitude =0.4f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        MoveUpAndDown();
    }
    void MoveUpAndDown()
    {
        float f = Mathf.Sin(Time.time);
        float y = f * Amplitude;
        Vector3 pos = transform.localPosition;
        pos.y = y;
        transform.localPosition = pos;
    }
}
