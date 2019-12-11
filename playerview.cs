
using UnityEngine;

public class playerview : MonoBehaviour
{
    public Transform player;
    public Vector3 avec;
    public Vector3 plyer;
    // Update is called once per frame
    void Update()
    {
        transform.position = player.position + avec;
        if(Input.GetKey("p"))
       transform.position = player.position+plyer ;
    }
}
