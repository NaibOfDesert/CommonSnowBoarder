using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DustContronnler : MonoBehaviour
{
    [SerializeField] ParticleSystem dustEffect;
    [SerializeField] string groundTag;
    // Start is called before the first frame update

    void OnCollisionEnter2D(Collision2D collider)
    {
        if (collider.gameObject.tag == groundTag)
        {
            Debug.Log("Go!");
            dustEffect.Play();
        }
    }
    void OnCollisionExit2D(Collision2D collider)
    {
        if (collider.gameObject.tag == groundTag)
        {
            Debug.Log("Jump!");
            dustEffect.Stop();
        }
    }
}
