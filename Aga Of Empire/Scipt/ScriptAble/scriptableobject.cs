using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(fileName = "Build Features", menuName = "ScriptableObjects/Build Features")]

public class scriptableobject : ScriptableObject
{
    public float BuildingTimeHour;
    public float BuiltPrice;
    public GameObject Built;
    ButtonScipt buton;

    public Text buildresult;
    
    void Start()
    {
        buildresult.text = "Price : " + BuiltPrice.ToString() + "\n Built Time : " + BuildingTimeHour.ToString();
    }

}
