using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishController : MonoBehaviour
{
    [SerializeField] string playerTag;
    // Start is called before the first frame update
    void Start(){
        
    }

    // Update is called once per frame
    void Update(){
        
    }

    void OnTriggerEnter2D(Collider2D collider){
        if(collider.tag == playerTag)
        {
            Debug.Log("Finish");
        }
    }
}
