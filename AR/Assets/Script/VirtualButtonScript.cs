using UnityEngine;
using Vuforia;

public class VirtualButtonScript : MonoBehaviour, IVirtualButtonEventHandler
{
    public Interactable interactableObject;
    private VirtualButtonBehaviour virtualButton;
    private ControllerSample controller;
    private bool presed = false;
    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {
        presed = true;
        Debug.Log("Se presionó");
    }


    public void OnButtonReleased(VirtualButtonBehaviour vb)
    {
        presed = false;
        Debug.Log("Se levantó");
    }

    /// <summary>
    /// Awake is called when the script instance is being loaded.
    /// </summary>
    void Awake()
    {
        virtualButton = GetComponent<VirtualButtonBehaviour>();
    }

    void Start()
    {
        if (virtualButton != null)
        {
            virtualButton.RegisterEventHandler(this);
        }
    }

    public bool getButtonPressed(){
        return presed;
    }
}