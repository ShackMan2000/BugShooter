using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class healthBar : MonoBehaviour
{
    [SerializeField]
    private ScriptableObjectFloat HealthValue;


    private Image healthImage;

    private void Awake()
    {
        healthImage = GetComponent<Image>();
    }


    // Update is called once per frame
    void Update()
    {
        healthImage.fillAmount = HealthValue.currentValue/ HealthValue.maxValue;
    }
}