using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinRotate : MonoBehaviour
{
    public Transform coins;

    void Update()
    {
        coins.Rotate(150 * Time.deltaTime*2, 0, 0); 
    }
}
