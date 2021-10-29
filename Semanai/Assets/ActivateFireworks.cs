using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivateFireworks : MonoBehaviour
{
    [SerializeField] private GameObject fireworks;


    private void OnTriggerEnter(Collider other)
    {
        fireworks.SetActive(true);
    }
}
