using UnityEditor;
using UnityEngine;
using UnityEngine.UI;
using static UnityEngine.ParticleSystem;

[CustomEditor(typeof(scriptableobject))]
public class ButtonScipt : MonoBehaviour
{
    public Text butontext;
    public scriptableobject target;

    private void FixedUpdate()
    {
        target.buil(butontext);
    }

    public void InsateBuild()
    {
        target.buildInst();
    }
}
