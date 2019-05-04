using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class MoveAlongScroll : MonoBehaviour
{

    [SerializeField]
    private ScriptableObjectFloat scrollSpeed;



    private void Update()
    {
        transform.position -= new Vector3(0, scrollSpeed.currentValue, 0);
    }

}
