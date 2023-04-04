using UnityEditor;
using UnityEngine;
using UnityEngine.UI;
[CustomEditor(typeof(scriptableobject))]
public class ButtonScipt : MonoBehaviour
{
    public Text text;
    private scriptableobject built;

    private void Start()
    {
        var script = built;
    }

    private void FixedUpdate()
    {

        built.buildresult = text;
    }
}
