using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camtrol : MonoBehaviour
{
    public Rigidbody playerToFollow;
    private Camera cam;
    // Start is called before the first frame update
    void Start()
    {
        cam = GetComponent<Camera>();
        cam.transform.position = playerToFollow.transform.position + new Vector3(0, 2, -10);

    }

    // Update is called once per frame
    void Update()
    {
        cam.transform.position = playerToFollow.transform.position + new Vector3(0, 2, -10);
        cam.transform.position = new Vector3(0, 2, cam.transform.position.z);
    }
}
