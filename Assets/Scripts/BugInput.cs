using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BugController : MonoBehaviour
{

    private Rigidbody2D rb;
    [SerializeField]
    private float speed;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        float horizontalSpeed = Input.GetAxis("Horizontal") * speed;
        float verticalSpeed = Input.GetAxis("Vertical") * speed;


        // translation *= Time.deltaTime;

        rb.velocity = new Vector2(horizontalSpeed, verticalSpeed);

       // transform.Translate(0, 0, translation);
    }
}
