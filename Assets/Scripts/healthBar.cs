using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class healthBar : MonoBehaviour
{
    [SerializeField]
    private ScriptableObjectFloat HealthValue;
    
    
    private Image healthImage;

    private Vector3 goodKarmaScale, badKarmaScale;

    private Image spriteRenderer;

    private void Awake()
    {
        healthImage = GetComponent<Image>();
        goodKarmaScale = transform.localScale;
        badKarmaScale = new Vector3(-transform.localScale.x, transform.localScale.y, transform.localScale.z);
        spriteRenderer = GetComponent<Image>();
    }


    // Update is called once per frame
    void Update()
    {
        if (HealthValue.currentValue > 0)
        {
            transform.localScale = goodKarmaScale;
            healthImage.fillAmount = HealthValue.currentValue / HealthValue.maxValue;
        }
        else
        {
            transform.localScale = badKarmaScale;
            healthImage.fillAmount = HealthValue.currentValue / -HealthValue.maxValue;
        }



    }
}