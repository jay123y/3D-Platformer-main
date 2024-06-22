using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.SceneManagement;

public class finishlvl1 : MonoBehaviour
{
    private void OnCollisionEnter(Collision other) {
        if(other.transform.tag == "Player"){
            SceneManager.LoadScene(1);
    }
    }
}
