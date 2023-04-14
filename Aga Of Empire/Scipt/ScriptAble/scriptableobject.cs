using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(fileName = "Build Features", menuName = "ScriptableObjects/Build Features")]

public class scriptableobject : ScriptableObject
{
    public float BuildingTimeHour;
    public float BuiltPrice;
    public GameObject Built;
    public Transform buildInsate;

    public void buil(Text buildresult)
    {
        buildresult.text = "Price : " + BuiltPrice.ToString() + "\n Built Time : " + BuildingTimeHour.ToString();
    }
    public void EdTi(float _BuildingTimeHour,float _BuiltPrice)
    {
        _BuildingTimeHour = BuildingTimeHour;
        _BuiltPrice = BuiltPrice;
    }
    public GameObject buildInst()
    {
        buildInsate.transform.position = new Vector3(buildInsate.transform.position.x+2, buildInsate.transform.position.y, buildInsate.transform.position.z+2);
        return Instantiate(Built, buildInsate.transform.position, Quaternion.identity);
    }

}
