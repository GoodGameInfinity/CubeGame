using UnityEngine;

public class MoveObstacle : MonoBehaviour
{
    public float speed = 15;
    public float percent = 20;
    public static MoveObstacle ins;

    private void Awake()
    {
        ins ??= this;
    }

    private void Update()
    {
        if(ScoreScript.ins._score >= percent)
        {
            percent += 10;
            speed += 5;
        }



        transform.Translate(Vector3.back * speed * Time.deltaTime);

        if(transform.position.z <= -5)
        {
            Destroy(gameObject);
        }
        
        Debug.Log("speed" + speed);
    }
}