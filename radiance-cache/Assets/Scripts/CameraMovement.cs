using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{

    public float moveSpeed = 5f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float mult = 1f;

        if(Input.GetKey(KeyCode.LeftShift)){
            mult = 0.5f;
        }

        if(Input.GetKey(KeyCode.A)){
            transform.Translate(transform.right * -moveSpeed * mult);
        }

        if(Input.GetKey(KeyCode.W)){
            transform.Translate(transform.forward * moveSpeed * mult);
        }

        if(Input.GetKey(KeyCode.S)){
            transform.Translate(transform.forward * -moveSpeed * mult);
        }
        
        if(Input.GetKey(KeyCode.D)){
            transform.Translate(transform.right * moveSpeed * mult);
        }

        if(Input.GetKey(KeyCode.Q)){
            transform.Translate(transform.up * moveSpeed * mult);
        }
        
        if(Input.GetKey(KeyCode.E)){
            transform.Translate(transform.up * -moveSpeed * mult);
        }
    }
}
