using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControllerSample : MonoBehaviour
{
    // Start is called before the first frame update
    public Animator _animator;
    public VirtualButtonScript[] virtualButton;
    void Awake()
    {
        _animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (virtualButton[0].getButtonPressed())
        {
            _animator.SetBool("Attack", true);
        }
        else
        {
            _animator.SetBool("Attack", false);
        }

        if (virtualButton[1].getButtonPressed())
        {
            _animator.SetBool("Run", true);
        }
        else
        {
            _animator.SetBool("Run", false);
        }

        if (virtualButton[2].getButtonPressed())
        {
            _animator.SetBool("Fly", true);
        }
        else
        {
            _animator.SetBool("Fly", false);
        }
    }
}

