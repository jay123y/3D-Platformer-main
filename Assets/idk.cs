using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class idk : MonoBehaviour

{
    public Transform destination;
    // Start is called before the first frame update
    private void OnCollisionEnter(Collision other){
    if(other.transform.tag == "Player")
    other.transform.position=destination.position;
    
        
    

    
        
    }
}
