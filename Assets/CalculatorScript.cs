using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CalculatorScript : MonoBehaviour
{
    [SerializeField] InputField input1;
    [SerializeField] InputField input2;
    [SerializeField] Text output;

    // Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void Add ()
    {
        int num1 = int.Parse(input1.text);
        int num2 = int.Parse(input2.text);
        int result = num1 + num2;
        output.text = result.ToString();
    }

    public void Subtract()
    {
        int num1 = int.Parse(input1.text);
        int num2 = int.Parse(input2.text);
        int result = num1 - num2;
        output.text = result.ToString();
    }

    public void Multiply()
    {
        int num1 = int.Parse(input1.text);
        int num2 = int.Parse(input2.text);
        int result = num1 * num2;
        output.text = result.ToString();
    }

    public void Divide()
    {
        int num1 = int.Parse(input1.text);
        int num2 = int.Parse(input2.text);
        int result = num1 / num2;
        output.text = result.ToString();
    }

    public void SwitchScene()
    {
        SceneManager.LoadScene("SimpleCalculator2");
    }
}
