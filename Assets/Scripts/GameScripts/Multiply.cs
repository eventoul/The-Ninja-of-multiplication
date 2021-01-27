using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Multiply : MonoBehaviour
{
    private string textMultiply;

    public int firstNumber;
    private int secondNumber = 0;

    public string Num
    {
        get
        {
            return textMultiply;
        }
        set
        {
            textMultiply = value;
            GetComponent<Text>().text = value;
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        secondNumber = Random.Range(1, 11);
        //Debug.Log("count of Rand = " + ++count);
        Num = firstNumber + " x " + secondNumber + " = ;";
    }

    /*// Update is called once per frame
    void Update()
    {


        if (!find)
        {

        }
    }*/

    // ana8eti nea tuxaia timi sto deutero ari8mo tis praksis 
    public void NewSecondNum()
    {
        /*int x = ResultOfMultiply(firstNumber, secondNumber);
        Debug.Log("product= " + x);*/

        secondNumber = Random.Range(1, 11);
        //Debug.Log("count of Rand = " + count++);
        Num = firstNumber + " x " + secondNumber + " = ;";
        

    }

    // epistefi tin timi tou ginomenou
    public int GetProduct()
    {
        int result = 0;

        result = ResultOfMultiply(firstNumber, secondNumber);
        //Debug.Log("1 MULTIPLY pro = " + result);

        return result;
    }
    
    // upologizei to ginomeno twn 2 ari8mwn
    private int ResultOfMultiply(int number1st, int number2nd)
    {
        int product = 0;

        product = number1st * number2nd;

        return product;
    }
}
