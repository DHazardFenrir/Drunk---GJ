using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class InteractWithRaycast : MonoBehaviour
{
    [SerializeField] private Camera mainCamera;
    [SerializeField] private float raycastDistance;
    [SerializeField] private UnityEvent<float> getDrunk;
    [SerializeField] private UnityEvent<float> getSober;
    [SerializeField] private UnityEvent<int> heal;

    private void Start()
    {
        mainCamera = Camera.main;
    }

    void Update()
    {
        RaycastFromCamera();
    }

    RaycastHit hit;

    private void RaycastFromCamera()
    {
        Ray ray = mainCamera.ScreenPointToRay(Input.mousePosition);
        Debug.DrawRay(ray.origin, ray.direction, Color.red);
        if(Physics.Raycast(ray.origin,ray.direction, out hit,raycastDistance))
        {
            if(Input.GetKeyDown(KeyCode.E) && hit.collider.CompareTag("Interactable"))
            {
                if(hit.collider.TryGetComponent<BottleOfAlcohol>(out BottleOfAlcohol bottle))
                {
                    getDrunk.Invoke(bottle.Alcohol);
                }

                if(hit.collider.TryGetComponent<HealEffect>(out HealEffect healEffect))
                {
                    getSober.Invoke(healEffect.Soberness);
                    heal.Invoke(healEffect.HealAmount);
                }

                hit.collider.GetComponent<IInteractable>().Interact();
            }
        }
    }

}
