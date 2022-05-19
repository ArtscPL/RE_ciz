using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System.Text;
using System;

public class CalculateState : MonoBehaviour
{
    public Camera camera;
    public TMP_Text[] TextShows;
    public GameObject[] Objects;
    private string[] stateValue;
    public string ResultCalculator;
    public string car;
    public int marbleIndex;
    public List<string> marbleValue = new List<string>();
    private int index = 0;
    // Start is called before the first frame update
    void Start()
    {
        SetStateValue();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void SetStateValue()
    {
        stateValue = new string[TextShows.Length];
        marbleIndex = 0;
        marbleValue = new List<string>();
        for (int i = 0 ;i < stateValue.Length-1 ;i++)
        {
            stateValue[i] = "";
            TextShows[i].text = stateValue[i];
        }
    }
    public void GetStateMarble(Marble marble)
    {
        int value = marble.number;
        for (int i = 0 ;i < stateValue.Length ;i++)
        {
            if (stateValue[i] == "")
            {
                Objects[i].SetActive(true);
                stateValue[i] = value.ToString();
                TextShows[i].text = stateValue[i];
                marbleIndex += 1;
                marbleValue.Add(value.ToString());
                break;
            }
        }
    }
    public void GetOperation(string operation)
    {
        string value = operation;
        for (int i = 0 ;i < stateValue.Length ;i++)
        {
            if (stateValue[i] == "")
            {
                Objects[i].SetActive(true);
                stateValue[i] = value;
                TextShows[i].text = stateValue[i];
                marbleIndex += 1;
                marbleValue.Add(value);
                break;
            }
        }
    }
    public int calculator()
    {
        StringBuilder builder = new StringBuilder();
        foreach (string safePrime in marbleValue)
        {
            // Append each int to the StringBuilder overload.
            builder.Append(safePrime);
        }
        string car = builder.ToString();
        string result = infixToPostfix(car);
        Debug.Log(result);
        result = expression(result);
        Debug.Log(result);
        Objects[9].SetActive(true);
        TextShows[9].text = result;
        int a = Convert.ToInt32(result);
        return a;
    }
    internal static int Prec(char ch)
    {
        switch (ch)
        {
        case '+':
        case '-':
            return 1;
 
        case '*':
        case '/':
            return 2;
 
        case '^':
            return 3;

        case '!':
            return 4;
        }
        return -1;
    }
 
    // The main method that converts given infix expression
    // to postfix expression. 
    public static string infixToPostfix(string marble)
    {
        // initializing empty String for result
        string result = "";
 
        // initializing empty stack
        Stack<char> stack = new Stack<char>();
 
        for (int i = 0; i < marble.Length; ++i)
        {
            char c = marble[i];
 
            // If the scanned character is an
            // operand, add it to output.
            if (char.IsLetterOrDigit(c))
            {
                result += c;
            }
 
            // If the scanned character is an '(',
            // push it to the stack.
            else if (c == '(')
            {
                stack.Push(c);
            }
 
            //  If the scanned character is an ')',
            // pop and output from the stack 
            // until an '(' is encountered.
            else if (c == ')')
            {
                while (stack.Count > 0 &&
                        stack.Peek() != '(')
                {
                    result += stack.Pop();
                }
 
                if (stack.Count > 0 && stack.Peek() != '(')
                {
                    return "Invalid Expression"; // invalid expression
                }
                else
                {
                    stack.Pop();
                }
            }
            else // an operator is encountered
            {
                while (stack.Count > 0 && Prec(c) <=
                                  Prec(stack.Peek()))
                {
                    result += stack.Pop();
                }
                stack.Push(c);
            }
 
        }
 
        // pop all the operators from the stack
        while (stack.Count > 0)
        {
            result += stack.Pop();
        }
 
        return result;
    }
    public string expression(string value)
        {
            Stack i = new Stack();

            int First, Second, answer;
            for (int j = 0; j < value.Length; j++)
            {
                string c = value.Substring(j, 1);
                if (c.Equals("*"))
                {
                    string sFirst = (string)i.Pop();
                    string sSecond = (string)i.Pop();
                    First = Convert.ToInt32(sFirst);
                    Second = Convert.ToInt32(sSecond);
                    answer = First * Second;
                    i.Push(answer.ToString());
 
                }
                else if (c.Equals("/"))
                {
                    string sFirst = (string)i.Pop();
                    string sSecond = (string)i.Pop();
                    First = Convert.ToInt32(sFirst);
                    Second = Convert.ToInt32(sSecond);
                    answer = Second / First;
                    i.Push(answer.ToString());
                }
                else if (c.Equals("+"))
                {
                    string sFirst = (string)i.Pop();
                    string sSecond = (string)i.Pop();
                    First = Convert.ToInt32(sFirst);
                    Second = Convert.ToInt32(sSecond);
                    answer = First + Second;
                    i.Push(answer.ToString());
 
                }
                else if (c.Equals("-"))
                {
                    string sFirst = (string)i.Pop();
                    string sSecond = (string)i.Pop();
                    First = Convert.ToInt32(sFirst);
                    Second = Convert.ToInt32(sSecond);
                    answer = Second - First;
                    i.Push(answer.ToString());
                }
                else if (c.Equals("^"))
                {
                    string sFirst = (string)i.Pop();
                    string sSecond = (string)i.Pop();
                    First = Convert.ToInt32(sFirst);
                    Second = Convert.ToInt32(sSecond);
                    answer = (int)Mathf.Pow((float)Second,(float)First);
                    i.Push(answer.ToString());
                }
                else if (c.Equals("!"))
                {
                    string sFirst = (string)i.Pop();
                    First = Convert.ToInt32(sFirst);
                    int factorial = 1;
                    for (int number = 1; number <= First; number++)
                    {
                        factorial *= number;
                    }
                    answer = factorial;
                    i.Push(answer.ToString());
                }
                else
                {
                    i.Push(value.Substring(j, 1));
                }
            }
            ResultCalculator = (string)i.Pop();
            return ResultCalculator;
        }
        
}
