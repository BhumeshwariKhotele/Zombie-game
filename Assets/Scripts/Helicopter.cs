using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Helicopter : MonoBehaviour
{
    public AudioClip callHelicopterSound;
    private bool isCalledHelicopter = false;
    private AudioSource audioSource;
    Rigidbody helicopterRB;
    public GameObject helicopterPosition;
    public static Helicopter instance;

    // Start is called before the first frame update
    void Start()
    {
        instance = this;
        audioSource = GetComponent<AudioSource>();
        helicopterRB = GetComponent<Rigidbody>();
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

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag=="Helipad")
        {
            helicopterPosition.transform.position = this.transform.position;

        }
    }
}
