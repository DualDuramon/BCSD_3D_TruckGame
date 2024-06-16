using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PropellerRolling : MonoBehaviour
{
    public float propellerSpeed = 1000;

    void Update()
    {
        transform.Rotate(Vector3.forward * Time.deltaTime * propellerSpeed);
    }
}
