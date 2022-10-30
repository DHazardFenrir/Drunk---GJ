using UnityEngine;
using UnityEngine.UI;

public class HealthUIControl : MonoBehaviour
{
    [SerializeField] private Health healthStat;
    [SerializeField] private Slider slider;

    private void Awake()
    {
        slider.maxValue = healthStat.MaxHealth;
        slider.value = healthStat.CurrentHealth;
    }

    public void UpdateSlider(int newValue)
    {
        slider.value = newValue;
    }


}
