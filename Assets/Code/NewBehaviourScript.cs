using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{



private void OnTriggerEnter(Collider other){
other.GetComponent<HEALTH>().collectCoins(1);
    Destroy(gameObject);

}



}

