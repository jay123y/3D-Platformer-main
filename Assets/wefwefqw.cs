using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wefwefqw : MonoBehaviour
{
    public float jumpStrength = 7;

    private void OnTriggerEnter(Collider other) {
        other.GetComponent<Jump>().jumpStrength += jumpStrength;
    }

    private void OnTriggerExit(Collider other) {
        other.GetComponent<Jump>().jumpStrength -= jumpStrength;
    }
}
