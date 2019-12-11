using System;
using UnityEngine;

public class GuidePath : MonoBehaviour
{
    public Functions fun;
 void Update()
    {
        FindObjectOfType<Functions>().Right();
        fun.Invoke("right",0);
    }
}
