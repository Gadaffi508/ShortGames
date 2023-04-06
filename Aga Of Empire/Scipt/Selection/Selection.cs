using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Selection : MonoBehaviour
{
    public Material highMat;
    public Material selectmat;

    private Material originMat;
    private Transform highLight;
    private Transform selection;
    private RaycastHit raycast;

    public GameObject Mission;
    public bool selected;
    public bool dontwork=true;

    private void Update()
    {
        if (highLight != null)
        {
            highLight.GetComponentInChildren<Renderer>().material = originMat;
            highLight = null;
        }
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        if (!EventSystem.current.IsPointerOverGameObject() && Physics.Raycast(ray,out raycast))
        {
            highLight = raycast.transform;
            if (highLight.CompareTag("employee") && highLight != selection)
            {
                if (highLight.GetComponentInChildren<Renderer>().material != highMat)
                {
                    originMat = highLight.GetComponentInChildren<Renderer>().material;
                    highLight.GetComponentInChildren<Renderer>().material = highMat;
                }
            }
            else
            {
                highLight = null;
            }
        }

        if (Input.GetKey(KeyCode.Mouse0) && !EventSystem.current.IsPointerOverGameObject())
        {
            if (selection != null)
            {
                selection.GetComponentInChildren<Renderer>().material = originMat;
                selection = null;
            }
            if (!EventSystem.current.IsPointerOverGameObject() && Physics.Raycast(ray,out raycast))
            {
                selection = raycast.transform;
                if (selection.CompareTag("employee") && dontwork)
                {
                    selection.GetComponentInChildren<Renderer>().material = selectmat;
                    Mission.SetActive(true);
                    selected = true;
                }
                else
                {
                    selection = null;
                    Mission.SetActive(false);
                    selected = false;
                }
            }
        }
    }
}
