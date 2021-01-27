using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{

    /*public GameObject prefab;*/

    public GameObject[] prefabArray;

    public float timer;
    public float minimumX;
    public float maximumX;
    public float y;

    /*public Sprite[] sprites;*/

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Spawn", timer, timer);
    }

    /*// Update is called once per frame
    void Update()
    {
        
    }*/

    public void Spawn()
    {
        // petaei ari8mous se tuxaia 8esi
        /*GameObject instance = Instantiate(prefab);
        instance.transform.position = new Vector2(Random.Range(minimumX, maximumX), y);*/

        GameObject randomInstance = Instantiate(prefabArray[Random.Range(0, prefabArray.Length)]);
        randomInstance.transform.position = new Vector2(Random.Range(minimumX, maximumX), y);

        //gia na min emfanizontai ta sprites sunexos sto Hierarchy kai na einai emfoleumena sto spawner
        randomInstance.transform.SetParent(transform);

        // epilegei tyxaia ari8mo(sprite) gia na to efmanisei stin o8oni
        /*Sprite randomSpite = sprites[Random.Range(0, sprites.Length)];
        instance.GetComponent<SpriteRenderer>().sprite = randomSpite;*/
    }
}
