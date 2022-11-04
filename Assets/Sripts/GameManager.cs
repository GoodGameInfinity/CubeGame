using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject ShowFPS;

    void Start()
    {
        ShowFPS.SetActive(SaveSettings.IsShowFPS);
    }
}
