using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting.Dependencies.Sqlite;
using UnityEngine;

public class PlayerInteraction : MonoBehaviour
{
    [SerializeField] private float interactionRange = 1f;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            Debug.Log("Interaction key pressed");
            RaycastHit2D hit = Physics2D.Raycast(transform.position, Vector2.right, interactionRange, LayerMask.GetMask("Interactable"));
            if (hit.collider != null)
            {
                Debug.Log("Hit: " + hit.collider.name);
                IInteractable interactable = hit.collider.GetComponent<IInteractable>();
                if (interactable != null)
                {
                    interactable.Interact(gameObject); //THIS MUST BE THE PLAYER GAMEOBJECT
                }
            }
        }
    }

    void OnDrawGizmos()
    {
        Gizmos.color = Color.yellow;
        Gizmos.DrawLine(transform.position, transform.position + Vector3.right * interactionRange);
    }
}
