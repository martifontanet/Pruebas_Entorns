using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChangerZone : MonoBehaviour
{
    public GameObject Ramp;
    private Material Rampamaterial;

    void Start()
    {
        Rampamaterial = GetComponent<Renderer>().material;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<Collider>().tag == "pilotaVermella")
        {
            var red = new Color(1, 0, 0);
            Ramp.GetComponent<MeshRenderer>().material.color = red;
        }
        else if (other.GetComponent<Collider>().tag == "pilotaBlava")
        {
            var blue = new Color(0, 0, 1);
            Ramp.GetComponent<MeshRenderer>().material.color = blue;
            /*Rampamaterial.SetColor("_Color", Color);
            Rampamaterial.SetColor("_EmissionColor", Color);*/
        }
    }

    private void OnTriggerExit(Collider other)
    {
        var Color = new Color(1, 1, 1); //RGB
        Ramp.GetComponent<MeshRenderer>().material.color = Color;
        /*Rampamaterial.SetColor("_Color", Color);
        Rampamaterial.SetColor("_EmissionColor", Color);*/
    }

    void SetRampColor(Color color)
    {
        Ramp.GetComponent<MeshRenderer>().material.color = color;
    }
}
