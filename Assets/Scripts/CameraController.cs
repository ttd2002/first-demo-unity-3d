using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    // Start is called before the first frame update
    Vector3 offset;
    public GameObject player;
    void Start()
    {
        offset = new Vector3(7f, 1.5f, 0);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = player.transform.position + offset;
    }
    
}
