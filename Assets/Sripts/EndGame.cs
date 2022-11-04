using UnityEngine;
using TMPro;

public class EndGame : MonoBehaviour
{
    public Transform _destrPlayer;
    public GameObject DestrPlayer;
    public GameObject EscapePanel;
    public GameObject worldCamera;
    public GameObject Obstacle;

    private void Update()
    {
        if(_destrPlayer.position.y <= 0.9f)
        {
            EscapePanel.SetActive(true);
            DestrPlayer.SetActive(false);
            worldCamera.gameObject.SetActive(true);
        }
    }


    private void OnTriggerEnter()
    {
        if(Obstacle.gameObject.tag == "Obstacle")
        {
            EscapePanel.SetActive(true);
            DestrPlayer.SetActive(false);
            worldCamera.gameObject.SetActive(true);
        }
    }
}
