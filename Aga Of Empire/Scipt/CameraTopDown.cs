using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraTopDown : MonoBehaviour
{
    public Transform _charecter;

    private void LateUpdate()
    {
        transform.position = new Vector3(_charecter.transform.position.x,10, _charecter.transform.position.z-10.0f);
    }
}
