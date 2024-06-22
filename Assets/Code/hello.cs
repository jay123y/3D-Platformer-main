using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hello : MonoBehaviour
{
    public float speed;
    public int damage = 25;
    void Update()
    
    {
      transform.Translate (0,0,speed * Time.deltaTime);  
    }


private void OnTriggerEnter(Collider other) {
  if (other.transform.tag=="Enemy")
  {
    other.GetComponent<Enemy>().TakeDamage(damage);
    Destroy(gameObject);
  }
}
}
