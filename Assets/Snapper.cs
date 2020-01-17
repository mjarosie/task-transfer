using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Snapper : MonoBehaviour
{
    public GameObject PartToAttach;
    bool inSocket = false;
    Transform socketObject;

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject == PartToAttach)
        {
            socketObject = other.transform;
            socketObject.parent = this.transform;
            socketObject.localPosition = Vector3.zero;
            socketObject.localRotation = this.transform.localRotation;
            
            inSocket = true;
        }
    }

    private void Update()
    {
        if(inSocket)
        {
            socketObject.localPosition = Vector3.zero;
        }
    }

}
