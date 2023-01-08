using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RockSpawner : MonoBehaviour
{
    [SerializeField]
    GameObject prefabRock;

    // store all possible rocks that can be spawned
    public Sprite[] sprites;

    int xPosition = Screen.width / 2;
    int yPosition = Screen.height / 2;

    float spawnTimeDelay = 1;
    float spawnTimeElapsed = 0;

    Vector2 centerPoint;

    // track how many rocks are currently spawned
    public int rockCount = 0;

    // Start is called before the first frame update
    void Start()
    {
        centerPoint = new Vector2(xPosition, yPosition);
    }

    // Update is called once per frame
    void Update()
    {
        spawnTimeElapsed += Time.deltaTime;

        if (spawnTimeElapsed >= spawnTimeDelay && rockCount < 3) 
        {
            SpawnRock();
            spawnTimeElapsed = 0;
            rockCount++;
        }
    }

    void SpawnRock()
    {


        Vector3 location = new Vector3(centerPoint.x,
            centerPoint.y,
            -Camera.main.transform.position.z);
        Vector3 worldLocation = Camera.main.ScreenToWorldPoint(location);
        GameObject rock = Instantiate(prefabRock) as GameObject;
        rock.transform.position = worldLocation;


        int randomSprite = Random.Range(0, sprites.Length);
        SpriteRenderer rockSprite = rock.GetComponent<SpriteRenderer>();
        rockSprite.sprite = sprites[randomSprite];
    }
}
