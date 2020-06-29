using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class vbInterface : MonoBehaviour, IVirtualButtonEventHandler
{
    VirtualButtonBehaviour[] virtualButtonBehaviours;
    string vbname;
    public GameObject btn1, btn2, btn3, btn4, btn5, nv, allerg, desc, alter, text;
    void Start()
    {
        virtualButtonBehaviours = GetComponentsInChildren<VirtualButtonBehaviour>();

        for (int i = 0; i < virtualButtonBehaviours.Length; i++)
            virtualButtonBehaviours[i].RegisterEventHandler(this);
    }

    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {
        vbname = vb.VirtualButtonName;

        if (vbname == "btn1")
        {
            deactivate();
            Btn1();
        }
        else if (vbname == "btn2")
        {
            deactivate();
            Btn2();
        }
        else if (vbname == "btn3")
        {
            deactivate();
            Btn3();
        }
        else if (vbname == "btn4")
        {
            deactivate();
            Btn4();
        }
        else if (vbname == "btn5")
        {
            deactivate();
            Btn5();
        }
    }

    public void OnButtonReleased(VirtualButtonBehaviour vb)
    {

    }
    public void deactivate()
    {
        nv.SetActive(false);
        desc.SetActive(false);
        allerg.SetActive(false);
        alter.SetActive(false);
        text.SetActive(false);
    }
    void Btn1()
    {
        desc.SetActive(true);
        text.SetActive(true);
    }
    void Btn2()
    {
        nv.SetActive(true);
        text.SetActive(true);
    }
    void Btn3()
    {
        allerg.SetActive(true);
        text.SetActive(true);
    }
    void Btn4()
    {
        alter.SetActive(true);
        text.SetActive(true);
    }
    void Btn5()
    {
        deactivate();
    }

}
