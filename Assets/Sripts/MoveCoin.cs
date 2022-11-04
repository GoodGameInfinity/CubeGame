using UnityEngine;

public class MoveCoin : MonoBehaviour
{
    public float speedCoin = 15;
    public static MoveCoin ins;

    private void Awake()
    {
        ins ??= this;
    }

    private void Update()
    {
        if(ScoreScript.ins._score >= 20)
        {
            speedCoin = 20;
        }

        transform.Translate(Vector3.up * speedCoin * Time.deltaTime);

        if(transform.position.z <= -5)
        {
            Destroy(gameObject);
        }

        Debug.Log("speedCoin: " + speedCoin);
    }
}
