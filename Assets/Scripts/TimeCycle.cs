using UnityEngine;

public class TimeCycle : MonoBehaviour
{
    public Rigidbody playerToFollow;
    public Transform l, childFollow;
    public float r = 0;
    // Start is called before the first frame update
    void Start()
    {
        l = GetComponent<Transform>();
        l.transform.position = playerToFollow.transform.position + new Vector3(0, 2, -10);

    }

    // Update is called once per frame
    void Update()
    {
        l.transform.position = playerToFollow.transform.position;
        l.transform.position = new Vector3(0, 2, l.transform.position.z);

        l.transform.eulerAngles = new Vector3(r, 0, r);
        r+=0.01f;        
    }
}

