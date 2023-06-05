using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElevatorButton : MonoBehaviour
{
    public bool GoUp;
    public Animator ElevatorAnimator;


    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit))
            {
                if (hit.collider.gameObject.name == "UpButton")
                {
                    ElevatorAnimator.SetBool("GoUp", true);
                }
                else if (hit.collider.gameObject.name == "DownButton")
                {
                    ElevatorAnimator.SetBool("GoUp", false);
                }
            }
        }
    }
}


