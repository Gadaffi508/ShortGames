using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class CharecterControlScript : MonoBehaviour
{
    public Camera cam;
    public NavMeshAgent player;
    public GameObject targetDest;
    public Animator anim;
    Selection select;
    private void Start()
    {
        anim = GetComponent<Animator>();
        select =GameObject.FindGameObjectWithTag("Selection").gameObject.GetComponent<Selection>();
    }

    private void Update()
    {
        if (this.select.selected==true)
        {
            if (Input.GetMouseButtonDown(0))
            {
                Ray ray = this.cam.ScreenPointToRay(Input.mousePosition);
                RaycastHit hitpoint;
                if (Physics.Raycast(ray, out hitpoint))
                {
                    this.targetDest.transform.position = hitpoint.point;
                    this.player.SetDestination(hitpoint.point);
                }
            }
        }

        if (this.player.velocity != Vector3.zero)
        {
            this.anim.SetBool("Move", true);
        }
        else if (player.velocity == Vector3.zero)
        {
            this.anim.SetBool("Move", false);
        }
    }
}
