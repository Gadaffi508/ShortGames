using UnityEditor;
using UnityEngine;
using UnityEngine.UI;
using static UnityEngine.ParticleSystem;

[CustomEditor(typeof(scriptableobject))]
public class ButtonScipt : MonoBehaviour
{
    public Text butontext;
    public scriptableobject target;
    public Camera cam;

    private void FixedUpdate()
    {
        target.buil(butontext);
    }

    public void InsateBuild()
    {
        Ray ray = this.cam.ScreenPointToRay(Input.mousePosition);
        RaycastHit hitpoint;
        if (Physics.Raycast(ray, out hitpoint))
        {
            target.buildInst(new Vector3(hitpoint.point.x, 3.1f, hitpoint.point.z));
        }
        
    }
}
