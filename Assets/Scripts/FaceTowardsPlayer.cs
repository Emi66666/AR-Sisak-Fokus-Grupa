using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FaceTowardsPlayer : MonoBehaviour
{

    [SerializeField] Camera Camera;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        transform.rotation = Quaternion.LookRotation(-Camera.main.transform.forward, Camera.main.transform.up);
    }
}
