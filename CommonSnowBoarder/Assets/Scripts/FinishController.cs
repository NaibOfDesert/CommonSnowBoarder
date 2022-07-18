using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishController : MonoBehaviour
{
    [SerializeField] string playerTag;
    [SerializeField] float invokeValue;
    [SerializeField] ParticleSystem finishEffect;

    // Start is called before the first frame update
    void Start()
    {
        invokeValue = 0.5f;
    }

    void OnTriggerEnter2D(Collider2D collider){
        if(collider.tag == playerTag)
        {
            finishEffect.Play();
            Debug.Log("It's end! You won!");
            GetComponent<AudioSource>().Play();
            Invoke("ReloadScene", invokeValue);
            
        }
    }

    void ReloadScene()
    {
        SceneManager.LoadScene(0);
    }

}
