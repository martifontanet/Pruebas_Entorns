using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChangeBox : MonoBehaviour
{
    public GameObject rampa;
    // Start is called before the first frame update
    private void OnCollisionStay(Collision other)
    {
        if (other.gameObject.tag == "pilotaBlava")
        {
            rampa.GetComponent<MeshRenderer>().material.color = Color.blue;
        }
        if (other.gameObject.tag == "pilotaVermella")
        {
            rampa.GetComponent<MeshRenderer>().material.color = Color.red;
        }
    }

}
