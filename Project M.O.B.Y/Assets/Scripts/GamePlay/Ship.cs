using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ship : MonoBehaviour, IInteractable
{
    public bool Interactable { get; set; } = true;

    public void Interact(GameObject player)
    {
        if (Interactable)
        {
            Debug.Log("Interacting with the ship.");
        }
    }
}
