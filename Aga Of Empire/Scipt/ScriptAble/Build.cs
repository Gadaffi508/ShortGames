using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
[CustomEditor(typeof(scriptableobject))]
public class Build : MonoBehaviour
{
    CharecterControlScript player;
    public Camera cam;
    public scriptableobject target;
    bool selected=true;

    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("employee").gameObject.GetComponent<CharecterControlScript>();
    }

    private void OnMouseOver()
    {
        if (Input.GetMouseButtonDown(0) && player.selected==true)
        {
            player.player.SetDestination(transform.position);
        }
    }
    
    IEnumerator ýnstateHuman()
    {
        yield return new WaitForSeconds(2);
        target.InsateHuman(transform.position);
    }
    private void Update()
    {
        if (selected)
        {
            Ray ray = this.cam.ScreenPointToRay(Input.mousePosition);
            RaycastHit hitpoint;
            if (Physics.Raycast(ray, out hitpoint))
            {
                transform.position = new Vector3(hitpoint.point.x, 3.1f, hitpoint.point.z);
            }
        }
        if (Input.GetMouseButtonDown(1))
        {
            selected = false;
            StartCoroutine(ýnstateHuman());
        }

    }
}
