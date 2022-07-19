using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CrashDetector : MonoBehaviour
{
    [SerializeField] string groundTag;
    [SerializeField] float invokeValue;
    [SerializeField] ParticleSystem crashEffect;
    [SerializeField] ParticleSystem hurtEffect;
    [SerializeField] AudioClip audioClip;
    bool isCrashed; 

    // Start is called before the first frame update
    void Start()    
    {
        invokeValue = 0.5f;
        isCrashed = false;
    }

    void OnCollisionEnter2D(Collision2D collider)
    {
        if (collider.gameObject.tag == groundTag && !isCrashed)
        {
            isCrashed = true;
            FindObjectOfType<PlayerController>().DisablePlayerController();
            crashEffect.Play();
            hurtEffect.Play();
            Debug.Log("It's hurt! Start again!");
            GetComponent<AudioSource>().PlayOneShot(audioClip);
            Invoke("ReloadScene", invokeValue);   
        }
    }

    void ReloadScene(){
        SceneManager.LoadScene(0);
    }
    
}
