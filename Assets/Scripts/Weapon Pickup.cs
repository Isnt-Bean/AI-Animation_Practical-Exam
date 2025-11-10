using System;
using UnityEngine;

public class WeaponPickup : MonoBehaviour
{
    public GameObject WeaponToReplace;
    public GameObject ThisObject;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        WeaponToReplace.SetActive(false);
    }

    void Update()
    {
        
    }
}
