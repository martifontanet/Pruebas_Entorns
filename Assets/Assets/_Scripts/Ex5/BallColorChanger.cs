using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallColorChanger : MonoBehaviour
{
    public Renderer BallRanderer;
    // Start is called before the first frame update
    
    public void SetRandomBallColor()
    {
        
            Vector3 pos = transform.position;

            var rot = Quaternion.Euler(0, 0, 0);
            var color = new Color(Random.value, Random.value, Random.value, 1);
            BallRanderer.GetComponent<Renderer>().material.SetColor("_Color", color);
        
    }
}
