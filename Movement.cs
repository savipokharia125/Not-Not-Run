
using UnityEngine;

public class Movement : MonoBehaviour
{
   // public float count = 0;
    public Transform obstacle;
    void Update()
    {
       
        obstacle.transform.Translate(4 * Time.deltaTime, 0, 0);
           
      
    }
}
