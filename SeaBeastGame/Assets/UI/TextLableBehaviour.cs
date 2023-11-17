using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

[RequireComponent(typeof(TextMesh))]
public class TextLableBehaviour : MonoBehaviour
{
    //Script was made my Anthony Romrell
    private TextMeshProUGUI label;
    public UnityEvent startEvent, updateEvent;
    public UnityEvent raiseEvent;
    public GameAction raiseScore;
    
    
    void Start()
    {
        label = GetComponent<TextMeshProUGUI>();
        startEvent.Invoke();
        raiseScore.raise += RaiseScore;
    }

    public void UpdateLabel(FloatData obj)
    {
        label.text = obj.value.ToString(CultureInfo.InvariantCulture);
        updateEvent.Invoke();
    }

    public void RaiseScore()
    {
       raiseEvent.Invoke();
    }



}
