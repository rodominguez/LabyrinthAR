using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger : MonoBehaviour
{

    [SerializeField] private Animator animator;
    [SerializeField] private string parameter;

    private bool isTriggered;

    private void OnTriggerEnter(Collider other)
    {
        if (!isTriggered)
            animator.SetBool(parameter, true);

        isTriggered = true;
    }
}
