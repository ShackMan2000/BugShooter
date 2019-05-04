using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Ground : MonoBehaviour
{
    // Scroll main texture based on time
    [SerializeField] private ScriptableObjectFloat scrollSpeed;

    Renderer rend;

    void Start()
    {
        rend = GetComponent<Renderer>();
    }

    void Update()
    {
        float offset = Time.time * scrollSpeed.currentValue;
        rend.material.SetTextureOffset("_MainTex", new Vector2(0, -offset));
    }
}