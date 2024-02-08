using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponSpawner : MonoBehaviour
{
    public GameObject prefab;
    
    public void spawnWeapon()
    {
        Instantiate(prefab, transform.position, transform.rotation);
    }
}
