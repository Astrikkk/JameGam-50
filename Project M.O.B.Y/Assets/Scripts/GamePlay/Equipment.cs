using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Equipment : MonoBehaviour, IInteractable
{
    [SerializeField] private bool isBroken = false;
    [SerializeField] private GameObject alertSign; //Appear on top of broken equipment to show that it is broken, get atention
    [SerializeField] private GameObject fixMenu;
    [SerializeField] private GameObject actionMenu;

    public bool Interactable { get; set; }

    private void BreakDown()
    {
        //activate animation and state
        isBroken = true;
        alertSign.SetActive(false);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            if (isBroken)
            {
                alertSign.SetActive(true);
            }
            else
            {
                alertSign.SetActive(false);
            }
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            alertSign.SetActive(false);
            fixMenu.SetActive(false);
        }
    }
    
    public void Interact(GameObject player)
    {
        if (isBroken)
        {
            fixMenu.SetActive(true);
            alertSign.SetActive(false);
        }
    }
}
