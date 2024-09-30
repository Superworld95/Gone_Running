using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sidewalk : EnemyAction
{
    bool isFacingRight = false;
    // Start is called before the first frame update
    void Start()
    {
        enemyObj = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log(isFacingRight);
        if (!isFacingRight)
        {
            enemyObj.velocity = new Vector3(enemyObj.position.x - 9F, enemyObj.velocity.y, enemyObj.velocity.z);
        } else
        {
            enemyObj.velocity = new Vector3(enemyObj.position.x + 9F, enemyObj.velocity.y, enemyObj.velocity.z);
        }
        if (enemyObj.position.x > 7F)
        {
            isFacingRight = false;
        }
        else if (enemyObj.position.x < -7F)
        {
            isFacingRight = true;
        }

    }
}
