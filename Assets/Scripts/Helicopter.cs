using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Helicopter : MonoBehaviour
{
    public AudioClip callHelicopterSound;
    private bool isCalledHelicopter = false;
    private AudioSource audioSource;
    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButton("Helicopter") && isCalledHelicopter)
        {
            isCalledHelicopter = true;
            Debug.Log("Helicopter called");
            audioSource.clip = callHelicopterSound;
            audioSource.Play();
        }
    }
}
