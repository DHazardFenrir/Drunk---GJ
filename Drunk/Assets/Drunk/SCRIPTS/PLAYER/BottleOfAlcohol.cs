using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BottleOfAlcohol : MonoBehaviour, IInteractable
{

    [SerializeField][Range(0,1)] float alcoholAmmount;

    public float Alcohol
    {
        get => alcoholAmmount;
        set => alcoholAmmount = value;
    }

    public void Interact()
    {
        Destroy(this.gameObject);
    }

}
