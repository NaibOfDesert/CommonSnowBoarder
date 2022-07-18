using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] float torqueAmount;
    [SerializeField] float boostSpeed;
    [SerializeField] float baseSpeed;
    Rigidbody2D rigidbody2d;
    SurfaceEffector2D surfaceEffector2D;

    // Start is called before the first frame update
    void Start(){
        
        torqueAmount = 8f;
        boostSpeed = 30f;
        baseSpeed = 20f;
        rigidbody2d = GetComponent<Rigidbody2D>();
        surfaceEffector2D = FindObjectOfType<SurfaceEffector2D>();
    }

    // Update is called once per frame
    void Update(){
        RotatePlayer();
        RespondToBoost();
    }


    void RotatePlayer()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            rigidbody2d.AddTorque(torqueAmount);
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            rigidbody2d.AddTorque(-torqueAmount);
        }
    }
    private void RespondToBoost()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            surfaceEffector2D.speed = boostSpeed;
        }
        else surfaceEffector2D.speed = baseSpeed;
        
    }
}
