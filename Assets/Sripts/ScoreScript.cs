using UnityEngine;
using TMPro;

public class ScoreScript : MonoBehaviour
{
    public TMP_Text ScoreText;
    public GameObject DestrPlayer;
    public GameObject EscapePanel;
    public GameObject worldCamera;
    private GameObject Coin;
    public static bool IsMove;
    public int _score = 0;
    public static ScoreScript ins;

    private void Awake()
    {
        ins ??= this;
    }

    private void Start()
    {
        Coin = GetComponent<GameObject>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Coin")
        {
            _score++;
            Destroy(other.gameObject);
            ScoreText.text = "Score: " + _score;
        }
        if(other.gameObject.tag == "Obstacle")
        {
            EscapePanel.SetActive(true);
            DestrPlayer.SetActive(false);
            worldCamera.gameObject.SetActive(true);
        }
    }
}
