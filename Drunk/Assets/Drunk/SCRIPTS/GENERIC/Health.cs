using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Health : MonoBehaviour
{

    [Header("PlayerStats")]
    [SerializeField] private int health;
    [SerializeField] private int maxHealth;

    [Header("Events")]
    [SerializeField] private UnityEvent<int> OnReceiveDamage;
    [SerializeField] private UnityEvent OnZeroHealth;
    [SerializeField] private UnityEvent<int> onReceiveHealth;

    public int MaxHealth
    {
        get => maxHealth;
        set => maxHealth = value;
    }

    public int CurrentHealth
    {
        get => health;
        set => health = value;
    }

    public void ReciveveDamage(int damageAmount)
    {
        CurrentHealth -= damageAmount;
        OnReceiveDamage?.Invoke(CurrentHealth);
        Debug.Log(CurrentHealth);
        if (CurrentHealth <= 0)
        {
            OnZeroHealth?.Invoke();
        }
    }

    public void GainHealth(int gainAmount)
    {
        CurrentHealth += gainAmount;
        CurrentHealth = Mathf.Clamp(CurrentHealth, 0, maxHealth);
        onReceiveHealth?.Invoke(CurrentHealth);
    }

}
