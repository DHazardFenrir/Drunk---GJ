using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class DamageOnContact : MonoBehaviour
{

    [SerializeField] private int damageToMake = 10;
    [SerializeField] private string tagToCompare;
    [SerializeField] private UnityEvent OnTrigger;

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag(tagToCompare))
        {
            if(other.TryGetComponent(out Health health))
            {
                health.ReciveveDamage(damageToMake);
                Debug.Log("Daño recibido");
                OnTrigger?.Invoke();
            }
            else
            {
                Debug.LogWarning("No se encontró el componente de Vida");
            }
        }
    }



}
