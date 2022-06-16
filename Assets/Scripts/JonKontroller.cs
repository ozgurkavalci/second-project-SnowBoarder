using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JonKontroller : MonoBehaviour
{
    Rigidbody2D rb2d;
    [SerializeField] float torqueamount=0.5f;
    [SerializeField] float boostSpeed=35f;

    [SerializeField] float baseSpeed=20f;

    SurfaceEffector2D surfaceEffector2D;

    bool canMove=true;

    // Start is called before the first frame update
    void Start()
    {
         rb2d=GetComponent<Rigidbody2D>();
         surfaceEffector2D=FindObjectOfType<SurfaceEffector2D>();
    }

    // Update is called once per frame
    void Update()
    {
      if(canMove)
       { 
         RotatePlayer();
         RespondToBoost();
       }
    }

    public void DisableCOntrols()
    {
      canMove=false;
    

    }

    void RespondToBoost()
    {
        if(Input.GetKey(KeyCode.W))
        {
           surfaceEffector2D.speed=boostSpeed;


        }
        else 
        {
          surfaceEffector2D.speed=baseSpeed;

        }
    }

    void RotatePlayer()
    {
        if (Input.GetKey(KeyCode.A))
        {
            rb2d.AddTorque(torqueamount);


        }
        else if (Input.GetKey(KeyCode.D))
        {

            rb2d.AddTorque(-torqueamount);

        }
    }
}
