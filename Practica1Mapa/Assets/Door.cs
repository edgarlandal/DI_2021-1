using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : Interactable
{    
    
    private Rigidbody rb;
    public Vector3 vector3;
    // Start is called before the first frame update
    public void Start()
    {
        vector3 = new Vector3(0, 4000, 0);
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    public override void Update()
    {
        base.Update();
    }

    public override void Interact()
    {   
        Quaternion deltaRotation = Quaternion.Euler(vector3 * Time.deltaTime);
        rb.MoveRotation(rb.rotation * deltaRotation);
    }
}
