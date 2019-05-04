using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Ground : MonoBehaviour
{
    // Scroll main texture based on time
    [SerializeField] private ScriptableObjectFloat scrollSpeed;

    Renderer rend;

    private float backOffset;

    void Start()
    {
        rend = GetComponent<Renderer>();
    }

    void Update()
    {
        backOffset -= Time.deltaTime * scrollSpeed.currentValue;
      //  float offset = Time.time * scrollSpeed.currentValue;
        rend.material.SetTextureOffset("_MainTex", new Vector2(0, backOffset));
    }
}