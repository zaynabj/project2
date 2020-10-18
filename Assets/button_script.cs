using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class button_script : MonoBehaviour
{
    public GameObject vButton;
    public Animator anim;
    public AudioSource audioSource;
    //public float delay = 1;

    // Start is called before the first frame update
    void Start()
    {
        vButton = GameObject.Find("VirtualButton");
        vButton.GetComponent<VirtualButtonBehaviour>().RegisterOnButtonPressed(OnButtonPressed);
        vButton.GetComponent<VirtualButtonBehaviour>().RegisterOnButtonReleased(OnButtonReleased);
        anim.GetComponent<Animator>();
    }

    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {
        //talkAnim.Play("talk");
        anim.SetTrigger("buttonPressed");
        audioSource.Play();
        Debug.Log("Button pressed");
    }

    public void OnButtonReleased(VirtualButtonBehaviour vb)
    {
        //talkAnim.Play("Dance");
        Debug.Log("Button released");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
