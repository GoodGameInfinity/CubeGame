using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EscapeManagment : MonoBehaviour
{
    public GameObject EscapePanel;

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape)) 
        {
            EscapePanel.SetActive(true);
        }
    }
}
