using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class PlayerController : Character
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.localRotation = Quaternion.Euler(0, -90, 0);
            Move();
        }
        else if(Input.GetKey(KeyCode.RightArrow))
        {
            transform.localRotation = Quaternion.Euler(0,90,0);
            Move();
        }
        else if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.localRotation = Quaternion.Euler(0,180,0);
            Move();
        }
        else if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.localRotation = Quaternion.Euler(0,0,0);
            Move();
        }
        else
        {
            Attack();
        }
    }
}
