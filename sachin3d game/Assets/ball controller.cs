using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballcontroller : MonoBehaviour
{
    public float movespeed = 5f;
    public float movescroll = 5f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        X = Input.GetGxis("Horizontal");
        Y = Input.GetAxis("Vertical");
    }
}
