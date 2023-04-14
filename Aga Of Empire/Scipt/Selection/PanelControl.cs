using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class PanelControl : MonoBehaviour
{
    public GameObject panel;
    bool oporcls;

    public void PanelOpCl()
    {
        oporcls = !oporcls;
        panel.SetActive(oporcls);
    }
}
