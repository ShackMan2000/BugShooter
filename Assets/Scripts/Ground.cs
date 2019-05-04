using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Ground : MonoBehaviour
{
    // Scroll main texture based on time
    [SerializeField] private ScriptableObjectFloat scrollSpeed;
    public Texture[] images;

    Renderer rend;

    private float backOffset;

    void Start()
    {
        rend = GetComponent<Renderer>();
        int BackgroundImage = Random.Range(0, images.Length);
        rend.material.mainTexture = images[BackgroundImage];
    }

    void Update()
    {
        backOffset -= Time.deltaTime * scrollSpeed.currentValue;
      //  float offset = Time.time * scrollSpeed.currentValue;
        rend.material.SetTextureOffset("_MainTex", new Vector2(0, backOffset));
    }
}