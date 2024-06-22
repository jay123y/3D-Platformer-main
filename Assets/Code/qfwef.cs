using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class qfwef : MonoBehaviour
{
    public float Speed = 7;
    public float runSpeed = 20;

    private void OnTriggerEnter(Collider other) {
        other.GetComponent<FirstPersonMovement>().speed += Speed;
        other.GetComponent<FirstPersonMovement>().runSpeed += runSpeed  ;
    }

    private void OnTriggerExit(Collider other) {
        other.GetComponent<FirstPersonMovement>().speed -= Speed;
        other.GetComponent<FirstPersonMovement>().runSpeed -= runSpeed  ;
        
    }
}
