using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RockSpawner : MonoBehaviour
{
    [SerializeField]
    GameObject prefabRock;

    int xPosition = Screen.width / 2;
    int yPosition = Screen.height / 2;

    float spawnTimeDelay = 2;
    float spawnTimeElapsed = 0;

    Vector2 centerPoint;

    // Start is called before the first frame update
    void Start()
    {
        centerPoint = new Vector2(xPosition, yPosition);
    }

    // Update is called once per frame
    void Update()
    {
        spawnTimeElapsed += Time.deltaTime;

        if (spawnTimeElapsed >= spawnTimeDelay) 
        {
            SpawnRock();
            // Instantiate<GameObject>(prefabRock, centerPoint, Quaternion.identity);
            spawnTimeElapsed = 0;
        }
    }

    void SpawnRock()
    {
        int rockChoice = Random.Range(0, 3);

        switch(rockChoice)
        {
            case 0:
                break;
            case 1:
                break;
            case 2:
                break;
            default:
                // An error occured
                // default to green rock
                break;
        }

        Vector3 location = new Vector3(centerPoint.x,
            centerPoint.y,
            -Camera.main.transform.position.z);
        Vector3 worldLocation = Camera.main.ScreenToWorldPoint(location);
        GameObject rock = Instantiate(prefabRock) as GameObject;
        rock.transform.position = worldLocation;
    }
}
