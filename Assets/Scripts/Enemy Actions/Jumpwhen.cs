using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jumpwhen : EnemyAction
{    
    bool isJumping = false;
    // Start is called before the first frame update
    void Start()
    {
        enemyObj = GetComponent<Rigidbody>();
        thePlayer = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (isJumping && thePlayer.velocity.y > 3f)
        {
            enemyObj.velocity = new Vector3(enemyObj.velocity.x, enemyObj.velocity.y + 5f, enemyObj.velocity.z);
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isJumping = true;
        }
    }
    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isJumping = false;
        }
    }
}
