using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class doorTrigger2 : MonoBehaviour {



    public Transform doorOpen;
    public bool doorOpened;
    public bool onTrigger;

    void OnTriggerEnter(Collider other)
    {
        onTrigger = true;
    }

    void OnTriggerExit(Collider other)
    {
        onTrigger = false;
    }

    void Update()
    {
        if (onTrigger == true)
        {
            doorOpened = true;
        }
        else
        {
            var newRotclosed = Quaternion.RotateTowards(doorOpen.rotation, Quaternion.Euler(0.0f, -90.0f, 0.0f), Time.deltaTime * 100);
            doorOpen.rotation = newRotclosed;
            doorOpened = false;
        }

        if (doorOpened == true)
        {
            var newRot = Quaternion.RotateTowards(doorOpen.rotation, Quaternion.Euler(0.0f, 0.0f, 0.0f), Time.deltaTime * 100);
            doorOpen.rotation = newRot;
        }
    }

}
