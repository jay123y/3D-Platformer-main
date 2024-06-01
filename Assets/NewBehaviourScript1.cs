using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class NewBehaviourScript1 : MonoBehaviour
{    private void OnCollisionEnter(Collision other) {
        if(other.transform.tag == "Player"){
        SceneManager.LoadScene(0);
    
        }}
    
    
        
    

    // Update is called once per frame
   
    
        
    
}
