using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class MoveAlongScroll : MonoBehaviour
{

    [SerializeField]
    private ScriptableObjectFloat scrollSpeed;
    private Rigidbody2D rb;

    [SerializeField]
    private float speedAdjustment;// = 1.0f;//;0.39f;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }


    private void Update()
    {
       // rb.velocity = new Vector2(0, -scrollSpeed.currentValue * 9);
       transform.position -= new Vector3(0, speedAdjustment * scrollSpeed.currentValue * Time.deltaTime, 0);
    }

}
