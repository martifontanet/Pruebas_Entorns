using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElevatorButton : MonoBehaviour
{
    public bool GoUp = true;
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
                    //if (GoUp)
                    //{
                        ElevatorAnimator.SetBool("Up", true);
                        ElevatorAnimator.SetBool("down", false);
                    GoUp = false;
                    //}
                }
                else if (hit.collider.gameObject.name == "DownButton")
                {
                    //if (GoUp)
                    //{
                        ElevatorAnimator.SetBool("down", true);
                        ElevatorAnimator.SetBool("Up", false);
                    GoUp = false;
                    //}
                    //else
                    //{
                    //    ElevatorAnimator.SetBool("Up", false);
                    //}
                    
                }
            }
        }
    }
}


