using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animation : MonoBehaviour
{
    public Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        // if(Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.S)){
        //     anim.SetBool("wallk", true);
        // }else{
        //     anim.SetBool("wallk", false);
            
        // }
        anim.SetFloat("posX", Input.GetAxis("Horizontal"), 0.1f, Time.deltaTime);
        anim.SetFloat("posY", Input.GetAxis("Vertical"), 0.1f, Time.deltaTime);
    }
}
