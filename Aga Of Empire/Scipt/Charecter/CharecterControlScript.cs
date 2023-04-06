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
    bool playerwork;
    private void Start()
    {
        anim = GetComponent<Animator>();
        select =GameObject.FindGameObjectWithTag("Selection").gameObject.GetComponent<Selection>();
        playerwork = true;
    }

    private void Update()
    {
        if (playerwork==true)
        {
            if (this.select.selected == true)
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
    public void BuiltStart()
    {
        Debug.Log("inþa baþladý");
        playerwork = false;
        select.dontwork = false;
        StartCoroutine(backwork());
    }
    IEnumerator backwork()
    {
        yield return new WaitForSeconds(5);
        playerwork = true;
        select.dontwork=true;
    }
}
