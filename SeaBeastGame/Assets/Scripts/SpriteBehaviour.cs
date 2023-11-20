using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(SpriteRenderer))]
public class SpriteBehaviour : MonoBehaviour
{
    public SpriteRenderer rendererObj;
    void Awake()
    {
        rendererObj = GetComponent<SpriteRenderer>();
    }
}
