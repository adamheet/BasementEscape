using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorTriggered : MonoBehaviour
{
    // Start is called before the first frame update

    public Animator doorAnim;
    void Start()
    {
       
    }

    // Update is called once per frame

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.name == "BoxKey")
        {
            doorAnim.SetBool("BoxKeyPlaced", true);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        doorAnim.SetBool("BoxKeyPlaced", false);
    }
}
