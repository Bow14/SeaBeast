using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
public class CollectionCollison : MonoBehaviour
{
    public UnityEvent collectionEvent;

    
    // Start is called before the first frame update
    void Start()
    {

    }


    public void OnTriggerEnter(Collider other)
    {
        collectionEvent.Invoke();
    }
}