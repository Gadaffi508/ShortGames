using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.AI;

[CustomEditor(typeof(scriptableobject))]
public class CharecterControlScript : MonoBehaviour
{
    public Camera cam;
    public NavMeshAgent player;
    public GameObject targetDest;
    public Animator anim;

    private void Start()
    {
        anim = GetComponent<Animator>();
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(1))
        {
            Ray ray = this.cam.ScreenPointToRay(Input.mousePosition);
            RaycastHit hitpoint;
            if (Physics.Raycast(ray, out hitpoint))
            {
                this.targetDest.transform.position = hitpoint.point;
                this.player.SetDestination(hitpoint.point);
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
