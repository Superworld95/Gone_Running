using UnityEngine;

public class Jumper : EnemyAction
{
    bool isJumping = false;
    // Start is called before the first frame update
    void Start()
    {
        enemyObj = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (isJumping)
        {
            enemyObj.velocity = new Vector3(enemyObj.velocity.x, enemyObj.velocity.y + 3f, enemyObj.velocity.z);
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
