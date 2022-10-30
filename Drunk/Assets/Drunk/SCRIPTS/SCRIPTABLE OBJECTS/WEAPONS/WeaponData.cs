using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "NewWeaponData", menuName ="Data/WeaponData")]
public class WeaponData : ScriptableObject
{
    public GameObject weaponPrefab;
    public GameObject proyectilePrefab;

    public float MaxDistance;
    public int damage;
    public float coolDown;

 
}
