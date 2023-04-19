using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
[CustomEditor(typeof(scriptableobject))]
public class Build : MonoBehaviour
{
    CharecterControlScript player;
    public Camera cam;
    public bool click=false;

    public scriptableobject target;

    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("employee").gameObject.GetComponent<CharecterControlScript>();
        StartCoroutine(ýnstateHuman());
    }

    private void OnMouseOver()
    {
        if (Input.GetMouseButtonDown(0) && player.selected==true)
        {
            player.player.SetDestination(transform.position);
        }
        if (Input.GetMouseButtonDown(1))
        {
            click = true;
        }
    }
    private void Update()
    {
        if (click)
            MousePosition();
        if (Input.GetMouseButtonDown(0))
        {
            click = false;
        }
    }
    public void MousePosition()
    {
        Ray ray = this.cam.ScreenPointToRay(Input.mousePosition);
        RaycastHit hitpoint;
        if (Physics.Raycast(ray, out hitpoint))
        {
            transform.position = new Vector3(hitpoint.point.x, transform.position.y,hitpoint.point.z);
        }
    }
    IEnumerator ýnstateHuman()
    {
        yield return new WaitForSeconds(2);
        target.InsateHuman();
        StartCoroutine(ýnstateHuman());
    }
}
