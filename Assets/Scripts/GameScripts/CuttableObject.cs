using UnityEngine;

public class CuttableObject : MonoBehaviour
{    

    public bool isRigth = true;

    /*// Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }*/

    /*
     * elexos epafis enos antikeimenou ariumos me tin lepida
     */
    private void OnCollisionEnter2D(Collision2D collision)
    {
        // topiki metabliti gia tin apo8ikeusi tou ginomenou tou pollaplasiasmou
        int product = 0;
        // topiki metabliti gia tin apo8ikeusi tis timis-value pou exei to noumero pou xtipaw
        int valueOfPrefab = 0;

        //stin topiki metabliti pernoume to value apo to noumero-Prefab
        valueOfPrefab = gameObject.GetComponent<MovementObject>().value;
        
        // apo to gameobject pou exei to to script Multiply pernoume to ginomeno tou polaplasiasmou
        product = GameObject.Find("Canvas/TextΜultiply").transform.GetComponent<Multiply>().GetProduct();
        
        // stin lepida exei apodo8ei to Tag Cut kai m' auto mporoume na kanoume ton elegxo
        if (collision.gameObject.CompareTag("Cut"))
        {
            // elegxos an to ginomeno einai iso me tin timi tou ari8mou pou ekopsa
            if (valueOfPrefab == product)
            {
                GameObject.Find("Canvas/ScoreDisplay").transform.GetComponent<ScoreDisplay>().Score += 1;
                GameObject.Find("Canvas/TextΜultiply").transform.GetComponent<Multiply>().NewSecondNum();
            }
            else
            {
                GameObject.Find("Canvas/ScoreDisplay").transform.GetComponent<ScoreDisplay>().Score -= 1;
            }
            // katastrofi tou antikimenou-ari8mou-Prefab
            Destroy(gameObject);
        }
    }
}
