using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinRotation : MonoBehaviour
{
    public float speedRot = 5;

    void Update()
    {
        //попрбывать без передвижения
        transform.Rotate(0.0f, 1.0f, 0.0f, Space.World);
    }
}
