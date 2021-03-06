﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class Interactable : MonoBehaviour
{
    public bool isInsideZone = false;
    public bool gazedAt = false;

    public float gazeInteractTime = 2f;
    public float gazeTimer = 0;
    // public KeyCode interactionKey = KeyCode.P;
    public string interactionButton = "Interact";
    
    /// <summary>
    /// Update is called every frame, if the MonoBehaviour is enabled.
    /// </summary>
    public virtual void Update()
    {
        // if (isInsideZone && Input.GetKeyDown(interactionKey))
        if (isInsideZone && CrossPlatformInputManager.GetButtonDown(interactionButton))
        {
            Interact();
        }
        if (gazedAt)
        {
            if ((gazeTimer += Time.deltaTime) >= gazeInteractTime)
            {
                Interact();
                gazedAt = false;
                gazeTimer = 0f;
            }
        }
    }

    /// <summary>
    /// OnTriggerEnter is called when the Collider other enters the trigger.
    /// </summary>
    /// <param name="other">The other Collider involved in this collision.</param>
    void OnTriggerEnter(Collider other)
    {
        if (!other.CompareTag("Player"))
        {
            return;
        }
        Debug.Log("Entró en el área");
        isInsideZone = true;
    }

    // /// <summary>
    // /// OnMouseDown is called when the user has pressed the mouse button while
    // /// over the GUIElement or Collider.
    // /// </summary>
    // void OnMouseDown()
    // {
    //     Interact();
    // }

    public void SetGazedAt(bool gazedAt)
    {
        this.gazedAt = gazedAt;
        if (!gazedAt)
        {
            gazeTimer = 0f;
        }
    }

    /// <summary>
    /// OnTriggerExit is called when the Collider other has stopped touching the trigger.
    /// </summary>
    /// <param name="other">The other Collider involved in this collision.</param>
    void OnTriggerExit(Collider other)
    {
        if (!other.CompareTag("Player"))
        {
            return;
        }
        Debug.Log("Salió en el área");
        isInsideZone = false;
    }

    public virtual void Interact()
    {

    }    
}