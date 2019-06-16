using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CalculatorScript2 : MonoBehaviour
{
    enum Operation { Void, Add, Subtract, Multiply, Divide };

    [SerializeField]Text displayText;

    int lastNum;
    Operation currOperation;
    bool newNum;

	void Start ()
    {
        PressReset();
	}

    public void PressNum(int num)
    {
        int currNum = int.Parse(displayText.text);
        if(newNum)
        {
            lastNum = currNum;
            currNum = 0;
            newNum = false;
        }
        if(currNum == 0)
        {
            currNum = num;
        }
        else
        {
            currNum = currNum * 10 + num;
        }
        displayText.text = currNum.ToString();
    }

    public void PressReset()
    {
        displayText.text = "0";
        lastNum = 0;
        currOperation = Operation.Void;
        newNum = false;
    }

    public void PressAdd()
    {
        if(currOperation != Operation.Void && !newNum)
        {
            Calculate();
        }
        currOperation = Operation.Add;
        newNum = true;
    }

    public void PressSubtract()
    {
        if (currOperation != Operation.Void && !newNum)
        {
            Calculate();
        }
        currOperation = Operation.Subtract;
        newNum = true;
    }

    public void PressMultiply()
    {
        if (currOperation != Operation.Void && !newNum)
        {
            Calculate();
        }
        currOperation = Operation.Multiply;
        newNum = true;
    }

    public void PressDivide()
    {
        if (currOperation != Operation.Void && !newNum)
        {
            Calculate();
        }
        currOperation = Operation.Divide;
        newNum = true;
    }

    private void Calculate()
    {
        int result = 0;
        int currNum = int.Parse(displayText.text);
        switch (currOperation)
        {
            case Operation.Void:
                result = currNum;
                break;
            case Operation.Add:
                result = lastNum + currNum;
                break;
            case Operation.Subtract:
                result = lastNum - currNum;
                break;
            case Operation.Multiply:
                result = lastNum * currNum;
                break;
            case Operation.Divide:
                result = lastNum / currNum;
                break;
        }
        currOperation = Operation.Void;
        displayText.text = result.ToString();
    }

    public void PressResult()
    {
        if (currOperation != Operation.Void && !newNum)
        {
            Calculate();
        }
        currOperation = Operation.Void;
        newNum = true;
    }

    public void SwitchScene()
    {
        SceneManager.LoadScene("SimpleCalculator1");
    }
}
