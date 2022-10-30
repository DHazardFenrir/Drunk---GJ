using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealEffect : MonoBehaviour,IInteractable
{

    [SerializeField] private int heal;
    [SerializeField] private float soberness;

    public int HealAmount
    {
        get => heal;
        set => heal = value;
    }

    public float Soberness
    {
        get => soberness;
        set => soberness = value;
    }

    public void Interact()
    {
        Destroy(this.gameObject);
    }

}
