using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Operation : MonoBehaviour
{
    public CalculateState calculateState;
    public string operation;
    // Start is called before the first frame update
    public void OnOperationButtonClick()
    {
        calculateState.GetOperation(operation);
    }
}
