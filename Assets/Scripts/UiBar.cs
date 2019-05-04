using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UiBar : MonoBehaviour
{
  
    [SerializeField]
    private ScriptableObjectFloat floatReference;


    
    private Text valueText;

    private void Awake()
    {
        valueText = GetComponent<Text>();
    }


    void Update()
    {
        valueText.text = floatReference.currentValue.ToString("F0");
    }
}
