using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Equipment : MonoBehaviour
{
    [SerializeField] private bool isWorking = true;
    [SerializeField] private bool isBroken = false;
    [SerializeField] private GameObject alertSign; //Appear on top of broken equipment to show that it is broken, get atention
    [SerializeField] private GameObject fixMenu;
    [SerializeField] private GameObject actionMenu;

    [SerializeField] private bool activePlayer = false;


    
    public void OpenFixMenu()
    {
        fixMenu.SetActive(true);
    }

    private void BreakDown()
    {
        //activate animation and state
        isWorking = false;
        isBroken = true;
        alertSign.SetActive(false);
    }

    private void ActionActivation(bool state) //will activate such things as menu, anumation and so on if needeed
    {
        activePlayer = state;
        if (isBroken == true) {
            actionMenu.SetActive(state);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            ActionActivation(true);
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            ActionActivation(false);
        }
    }
}
