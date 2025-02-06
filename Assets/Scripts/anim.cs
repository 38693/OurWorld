using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class anim : MonoBehaviour
{
    private Animator animController;
    // Start is called before the first frame update
    void Start()
    {
        animController = GetComponent<Animator>();
    }

    // Update is called once per frame 
    
    void Update()
    {
        if (animController != null)
        {
            if (Input.GetKeyDown(KeyCode.W))
            {
                animController.SetTrigger("Walk");
            }
        }

        if(animController != null)
        {
            if (Input.GetKeyDown(KeyCode.S))
            {
                animController.SetTrigger("Stop");
            }
        }
    } 
}
