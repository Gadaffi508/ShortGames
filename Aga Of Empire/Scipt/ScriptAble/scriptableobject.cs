using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(fileName = "Build Features", menuName = "ScriptableObjects/Build Features")]

public class scriptableobject : ScriptableObject
{
    public float BuildingTimeHour;
    public float BuiltPrice;
    public GameObject Built;
    public Transform buildInsate;
    public bool soldirandemplo;
    public GameObject soldir;
    public GameObject emploo;

    public void buil(Text buildresult)
    {
        buildresult.text = "Price : " + BuiltPrice.ToString() + "\n Built Time : " + BuildingTimeHour.ToString();
    }
    public void EdTi(float _BuildingTimeHour,float _BuiltPrice)
    {
        _BuildingTimeHour = BuildingTimeHour;
        _BuiltPrice = BuiltPrice;
    }
    public GameObject buildInst(Vector3 transformVec)
    {
        return Instantiate(Built, transformVec, Quaternion.identity);
    }
    public bool InsateHuman(Vector3 transformVec)
    {
        if (soldirandemplo==true)
        {
            return Instantiate(soldir, transformVec, Quaternion.identity);
        }
        else
        {
            return Instantiate(emploo, transformVec, Quaternion.identity);
        }
    }

}
