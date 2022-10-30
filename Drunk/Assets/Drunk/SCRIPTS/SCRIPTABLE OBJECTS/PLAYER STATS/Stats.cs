using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[CreateAssetMenu(fileName = "NewPlayerStat", menuName = "Stats/CreatePlayerStat", order = 1)]
public class Stats : ScriptableObject
{
    public float stamina;
    public float maxStamina;
    [Range(0,1)]public float drunkness;

    [Header("MoveStats")]
    public float normalSpeed;
    public float sprintSpeed;

    [Header("Events")]
    [SerializeField] private UnityEvent<int> OnReceiveDamage;
    [SerializeField] private UnityEvent OnZeroHealth;
    [SerializeField] private UnityEvent<int> onReceiveHealth;

   


}
