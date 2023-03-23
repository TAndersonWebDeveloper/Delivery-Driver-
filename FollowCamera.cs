using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCamera : MonoBehaviour
{
    [SerializeField] GameObject thingToFolow;
    void LateUpdate()
    {
        transform.position = thingToFolow.transform.position + new Vector3(0, 0, -10);
    }
}
