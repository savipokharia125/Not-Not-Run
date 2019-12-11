using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InAndOut : MonoBehaviour
{
    public float speed = 1f;
      
    public float sideforce = 200f;
    public Rigidbody rb;
    public GameObject player;
    public Transform[] path;
   static int current=0;
   
    void Update()
    {
        if (transform.position.z != path[current].position.z)
        {
            Vector3 pos = Vector3.MoveTowards(transform.position, path[current].position, speed * Time.deltaTime);
            GetComponent<Rigidbody>().MovePosition(pos);
        }
        else
            current = (current + 1 ) % path.Length;
        
    }
}
