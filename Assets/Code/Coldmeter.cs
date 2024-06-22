using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coldmeter : MonoBehaviour
{
    public float warmth = 100;
    public bool touchCampfire = false;
    public float recover =1;    

    private void Update() {
        print("Running");
        if (touchCampfire){
            print("Touch fire");
            warmth += recover;
        } else{
            print("Losing warmth");
            warmth -= Time.deltaTime;
        }   
        if(warmth <= 0){
            
            print("Losing health");
            transform.GetComponent<HEALTH>().TakeDamage(0.1f);
        }
    }
    private void OnTriggerEnter(Collider other) {
        if(other.transform.tag == "fire"){
            touchCampfire = true;
        }
    }
    private void OnTriggerExit(Collider other) {
        if(other.transform.tag == "fire"){
            touchCampfire = false;
        }
    }
}
