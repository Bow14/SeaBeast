using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class GameManager : MonoBehaviour
{
    public GameManager gameManagerObj;
    public IntData healthValue;
    public UnityEvent endGameEvent;

    public void Awake()
    {
        
    }
    
    public void LoseLife()
    {
        if (healthValue.value <= 0)
        {
            endGameEvent.Invoke();
        }
        else
        {
           Debug.Log("Screams in Death");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
