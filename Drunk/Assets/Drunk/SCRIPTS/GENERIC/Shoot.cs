using System.Collections;
using UnityEngine;

public class Shoot : MonoBehaviour
{

    [SerializeField] private WeaponData[] _weaponData;
    [SerializeField] private Transform weaponSpawn;
    private GameObject actualWeapon;
    private int actualWeaponIndex = 0;


    [SerializeField] private Transform shootOrigin;
    private bool canShoot = true;
    [SerializeField] private GameState gameState;

    private void Start()
    {
        actualWeapon = Instantiate(_weaponData[actualWeaponIndex].weaponPrefab, weaponSpawn.position, weaponSpawn.rotation);
        actualWeapon.transform.SetParent(weaponSpawn.transform);
        //StartCoroutine(FireRoutine());
        //StartCoroutine(ChangeWeapon());
    }

    //IEnumerator FireRoutine()
    //{
    //    //while (gameState.CurrentGameState == GameState.GameStateEnum.Playing)
    //    //{
    //    //    if (Input.GetKeyDown(KeyCode.Mouse0) && canShoot)
    //    //    {
    //    //        GameObject bullet = Instantiate(_weaponData[actualWeaponIndex].proyectilePrefab, shootOrigin.position, shootOrigin.rotation);
    //    //        canShoot = false;
    //    //        yield return new WaitForSeconds(_weaponData[actualWeaponIndex].coolDown);
    //    //        canShoot = true;
    //    //    }
    //    //}
    //}

    //IEnumerator ChangeWeapon()
    //{
    //    //while (gameState.CurrentGameState == GameState.GameStateEnum.Playing)
    //    //{
    //    //    if (Input.GetKeyDown(KeyCode.Alpha1))
    //    //    {
    //    //        actualWeaponIndex = 0;
    //    //        Destroy(actualWeapon.gameObject);
    //    //        actualWeapon = Instantiate(_weaponData[actualWeaponIndex].weaponPrefab, weaponSpawn.position, weaponSpawn.rotation);
    //    //        actualWeapon.transform.SetParent(weaponSpawn.transform);
    //    //    }
    //    //    else if(Input.GetKeyDown(KeyCode.Alpha2))
    //    //    {
    //    //        actualWeaponIndex = 1;
    //    //        actualWeapon = Instantiate(_weaponData[actualWeaponIndex].weaponPrefab, weaponSpawn.position, weaponSpawn.rotation);
    //    //        actualWeapon.transform.SetParent(weaponSpawn.transform);

    //    //    }
    //    //    else if(Input.GetKeyDown(KeyCode.Alpha3))
    //    //    {
    //    //        actualWeaponIndex = 2;
    //    //        actualWeapon = Instantiate(_weaponData[actualWeaponIndex].weaponPrefab, weaponSpawn.position, weaponSpawn.rotation);
    //    //        actualWeapon.transform.SetParent(weaponSpawn.transform);
    //    //    }
    //    //    yield return null;
    //    //}
    //}



}
