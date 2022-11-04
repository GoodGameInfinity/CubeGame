using UnityEngine;
using System.Collections;
using TMPro;

public class SpawnObject : MonoBehaviour
{
    public GameObject obj;
    public GameObject Coin;
    public TMP_Text Text;
    public GameObject worldCamera;
    float time = 0f;

    private void Start()
    {                                                                                 //145
        Vector3 pos = new Vector3(Random.Range(-2.59f, 2f), 1.181202f, Random.Range(125, 135));
        Instantiate(obj, pos, Quaternion.identity);

        Vector3 pos2 = new Vector3(Random.Range(-2.59f, 2f), 1.181202f, Random.Range(85, 105));
        Instantiate(obj, pos2, Quaternion.identity);

        Vector3 pos3 = new Vector3(Random.Range(-2.59f, 2f), 1.181202f, Random.Range(65, 60));
        Instantiate(obj, pos3, Quaternion.identity);

        StartCoroutine(Spawn());
        StartCoroutine(Spawn—oin());
    }

    IEnumerator Spawn()
    {
        while(true)
        {
            time = Random.Range(1f, 1.8f);
            Vector3 pos = new Vector3(Random.Range(-2.59f, 2f), 1.181202f, 180);
            Instantiate(obj, pos, Quaternion.identity);

            yield return new WaitForSeconds(time);
        }
    }

    IEnumerator Spawn—oin()
    {
        while(true)
        {
            time = Random.Range(1.2f, 1.5f);
            Vector3 pos = new Vector3(Random.Range(-8.3f, 7.3f), 1, 180);
            Instantiate(Coin, pos, Quaternion.Euler(-90, 0, 0));

            yield return new WaitForSeconds(time);
        }
    }
}
