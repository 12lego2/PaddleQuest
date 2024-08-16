using UnityEngine;

public class RandomizeBall : MonoBehaviour
{
    // Randomize an object at the start of the scene
    int randNum;
    public Ball ball, arrow;

    void Start()
    {
        randNum = Random.Range(0, 2);

        if (randNum == 0)
        {
            /*ball.SetActive(true);*/
        }
        if (randNum == 1)
        {
            /*arrow.SetActive(true);*/
        }
    }
}
