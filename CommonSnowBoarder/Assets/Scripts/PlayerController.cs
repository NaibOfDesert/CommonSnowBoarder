using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] float torqueAmount; 
    Rigidbody2D rigidbody2d;
    // Start is called before the first frame update
    void Start(){
        rigidbody2d = GetComponent<Rigidbody2D>();
        torqueAmount = 8f;
    }

    // Update is called once per frame
    void Update(){
        if (Input.GetKey(KeyCode.LeftArrow)){
            rigidbody2d.AddTorque(torqueAmount);
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            rigidbody2d.AddTorque(-torqueAmount);
        }
    }
}
