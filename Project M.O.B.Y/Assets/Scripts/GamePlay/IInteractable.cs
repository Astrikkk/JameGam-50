using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IInteractable
{
    bool Interactable { get; set; }
    void Interact(GameObject player);
}
