using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeCycle : MonoBehaviour
{
    public Rigidbody playerToFollow;
    private Light light;
    // Start is called before the first frame update
    void Start()
    {
        light = GetComponent<Light>();
        light.transform.position = playerToFollow.transform.position + new Vector3(0, 2, -10);

    }

    // Update is called once per frame
    void Update()
    {
        light.transform.position = playerToFollow.transform.position;
        light.transform.position = new Vector3(0, 2, light.transform.position.z);
        light.transform.rotation = new Quaternion(light.transform.rotation.x + 1f, 0f, 0f, 0f);
    }
}

