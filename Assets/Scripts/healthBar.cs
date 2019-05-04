using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class healthBar : MonoBehaviour
{
    [SerializeField] private ScriptableObjectFloat HealthValue;
    public Image healthImage;

    // Update is called once per frame
    void Update()
    {
        healthImage.fillAmount = HealthValue.currentValue;
    }
}