using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class BottonBehaviorScript : MonoBehaviour
{
    public GameObject cube;

    VirtualButtonBehaviour vbutton;

    // Start is called before the first frame update
    void Start()
    {
        cube.SetActive(false);

        vbutton = GetComponentInChildren<VirtualButtonBehaviour>();

        vbutton.RegisterOnButtonPressed(onBottonPressed);
        vbutton.RegisterOnButtonReleased(onBottonReleased);
    }

    void onBottonPressed(VirtualButtonBehaviour vb)
    {
        cube.SetActive(true);
    }

    void onBottonReleased(VirtualButtonBehaviour vb)
    {
        cube.SetActive(false);
    }
}
