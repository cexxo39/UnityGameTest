using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    //Variables
    public Transform player;
    Vector3 x = new Vector3(0.05f, 0, 0);
    Vector3 z = new Vector3(0, 0, 0.05f);
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("w"))
            player.position += x;
        if (Input.GetKey("s"))
            player.position -= x;
        if (Input.GetKey("a"))
            player.position += z;
        if (Input.GetKey("d"))
            player.position -= z;
    }
}
