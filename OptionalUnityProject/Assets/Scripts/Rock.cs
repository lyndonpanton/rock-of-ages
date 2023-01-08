using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rock : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        // apply impulse force to get game object moving
        const float MinImpulseForce = 1f;
        const float MaxImpulseForce = 2f;
        float angle = Random.Range(0, 2 * Mathf.PI);
        Vector2 direction = new Vector2(
            Mathf.Cos(angle), Mathf.Sin(angle));
        float magnitude = Random.Range(MinImpulseForce, MaxImpulseForce);
        GetComponent<Rigidbody2D>().AddForce(
            direction * magnitude,
            ForceMode2D.Impulse);

        Vector3 location = new Vector3(Screen.width / 2,
            Screen.height / 2,
            -Camera.main.transform.position.z);
        Vector3 worldLocation = Camera.main.ScreenToWorldPoint(location);
    }

    // Update is called once per frame
    void Update()
    {
        // min world x and y
        Vector3 minWorldLocation = Camera.main.ScreenToWorldPoint(
            new Vector3(
                0,
                0,
                -Camera.main.transform.position.z
            )
        );

        

        // max world x and y
        Vector3 maxWorldLocation = Camera.main.ScreenToWorldPoint(
            new Vector3(
                Screen.width,
                Screen.height,
                -Camera.main.transform.position.z
            )
        );

        // sprite size
        float spriteWidth = GetComponent<SpriteRenderer>().bounds.size.x;
        float spriteHeight = GetComponent<SpriteRenderer>().bounds.size.y;

        if (transform.localPosition.x < (minWorldLocation.x - spriteWidth / 2) ||
            transform.localPosition.x > (maxWorldLocation.x + spriteWidth / 2) || 
            transform.localPosition.y < (minWorldLocation.y - spriteHeight / 2) ||
            transform.localPosition.y > (maxWorldLocation.y + spriteHeight / 2))
        {
            Destroy(gameObject);
        }
    }
}
