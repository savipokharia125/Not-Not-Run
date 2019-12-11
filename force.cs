
using UnityEngine;

public class force : MonoBehaviour
{
    public Rigidbody rb;
   
    public int forwardforce=800;
    public float sideforce = 50f;
    //public float upforce = 0.1000f;
    // Update is called once per frame
    public int Speed()
     {
        return forwardforce;
    }
    void FixedUpdate()
    {
        rb.AddForce(0, 0, forwardforce * Time.deltaTime);
        if (Input.GetKey("d"))
        {
            rb.AddForce(sideforce * Time.deltaTime, 0, 0,ForceMode.VelocityChange);
        }

        if (Input.GetKey("s"))
        {
            rb.AddForce(-sideforce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (rb.position.y <= 0f)
        {
            FindObjectOfType<Management>().EndGame();
        }

       
    }
}
