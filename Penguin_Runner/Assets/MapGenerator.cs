using System.Collections.Generic;
using UnityEngine;

public class MapGenerator : MonoBehaviour {
    public List<GameObject> platforms;
    public Transform generationPoint;
    public float distanceBetweenObstacles;

    private float platformWidth;
    private int random = 0;
    private int lastRandom = 0;

    public float distanceBetweenObstaclesMin;
    public float distanceBetweenObstaclesMax;

    public ObjectPooler objectPool;

    private void Start()
    {
        platformWidth = 40;
    }

    private void Update()
    {
        if(transform.position.x < generationPoint.position.x)
        {
            // platforms
            transform.position = new Vector2(transform.position.x + platformWidth, transform.position.y);
            while(random == lastRandom)
            {
                random = Random.Range(0, platforms.Count-1);
            }
            lastRandom = random;
            Instantiate(platforms[random], transform.position, transform.rotation);

            /*
            GameObject newPlatform = objectPool.GetPooledObject();
            newPlatform.transform.position = transform.position;
            newPlatform.transform.rotation = transform.rotation;
            newPlatform.SetActive(true);
            */
        }
    }

}
