using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TIMERnoooooooooooo : MonoBehaviour
{
    
    public float seconds;
    public float minute;


    void Update(){
        seconds += Time.deltaTime;
        if (seconds >= 60){
        minute += 1;
        seconds -= 60;
        }
        print(Math.Floor(minute) + ":" + Math.Floor(seconds));
}
    
    

}
