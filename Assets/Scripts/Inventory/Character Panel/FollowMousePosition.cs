using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowMousePosition : MonoBehaviour
{
    // Start is called before the first frame update
    void LateUpdate()
    {
        transform.position = Input.mousePosition;
    }
}
