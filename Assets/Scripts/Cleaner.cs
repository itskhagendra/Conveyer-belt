using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// This is The pool Cleaner for the Object pool factory this Clears the object from Heirarchy for the objects to be reused
/// </summary>
public class Cleaner : MonoBehaviour
{
    private void OnEnable()
    {
        gameObject.GetComponent<Renderer>().enabled = false;
    }
    private void OnCollisionEnter(Collision collision)
    {
        collision.gameObject.SetActive(false);
    }
}
