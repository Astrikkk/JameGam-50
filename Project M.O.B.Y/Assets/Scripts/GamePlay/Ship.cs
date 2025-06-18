using System.Collections;
using System.Collections.Generic;
using TMPro.Examples;
using Unity.VisualScripting;
using UnityEngine;

public class Ship : MonoBehaviour, IInteractable
{
    [SerializeField] private ShipMovementMachine shipMovementMachine;
    bool flyingShip;
    private GameObject player;

    public bool Interactable { get; set; } = true;

    public void Interact(GameObject player)
    {
        if (Interactable)
        {
            this.player = player;
            player.SetActive(false); // Hide the player when interacting with the ship
            flyingShip = true;
            CameraMovement.Instance.target = gameObject; // Change camera target to the ship
        }
    }

    void Update()
    {
        if (!flyingShip)
        {
            return;
        }

        if (Input.GetKey(KeyCode.C))
        {
            CameraMovement.Instance.target = player;
            flyingShip = false;
            player.transform.position = transform.position;
            player.SetActive(true);
            return; 
        }

        if (Input.GetKey(KeyCode.E))
        {
            shipMovementMachine.Rotate(-1);
        }

        if (Input.GetKey(KeyCode.Q))
        {
            shipMovementMachine.Rotate(1);
        }
        
        if (Input.GetKey(KeyCode.W))
        {
            shipMovementMachine.MoveForward();
        }
    }
}