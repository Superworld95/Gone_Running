using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Player : MonoBehaviour
{
    public Rigidbody player;
    public float vel = 2, spd = 2, jumpHeight = 2, hTeleDist = 2, vTeleDist = 2;
    //public GameObject keyPlayer;
    float h;
    //bool isJumping = false, isGrounded = false, isRunning = false;
    //public float jumpHeight = 1f, walkAcc = 1f, runAcc = 2f, walkSpeedLimit = 2f, runSpeedLimit = 4f;
    //public Animator anim;
    [SerializeField] Runner _runner;
    [SerializeField] PlayerInput _playerInput;
    bool isJumping = false, isGrounded = false, canTeleport = false;
    // Start is called before the first frame update
    void Start()
    {
        _runner = new Runner();
        _runner.Enable();
        player = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        //print(h);
        if (player.velocity.z < spd)
        {
            player.velocity = Vector3.forward * vel;
        }
        h = _runner.Movement.Around.ReadValue<Vector2>().x;
        if (player.position.x > 9F)
        {
            player.velocity = new Vector3(-1f, player.velocity.y, player.velocity.z);
        } else if (player.position.x < -9F)
        {
            player.velocity = new Vector3(1f, player.velocity.y, player.velocity.z);
        } else
        {
            player.velocity = new Vector3(h * spd, player.velocity.y, player.velocity.z);
        }
        /*if (player.velocity.x < vel && player.velocity.x > -vel && player.position.x < 9F && player.position.x > -9F)
        {
            if (h == 1)
            {
                //anim.SetTrigger("Walking");
            }
            else if (h == -1)
            {
                //Enable walk left.
            }
            player.velocity = new Vector3(h * spd, player.velocity.y, player.velocity.z);
        }
        else
        {
            if (player.position.x < 9 && h == 1)
            {
                player.velocity = new Vector3(h * spd, player.velocity.y, player.velocity.z);
            }
            else if (player.position.x > -9F && h == -1)
            {
                player.velocity = new Vector3(h * spd, player.velocity.y, player.velocity.z);
            }            
        }*/
        isJumping = _runner.Jumping.Rise.inProgress;
        if (isJumping && isGrounded)
        {
            isGrounded = false;
            isJumping = false;
            player.velocity = new Vector3(player.velocity.x, player.velocity.y + jumpHeight, player.velocity.z);
            //anim.SetTrigger("Jumping");
        } else if (isJumping && !isGrounded && canTeleport && player.position.y > 3f)
        {
            canTeleport = false;
            isJumping = false;
            if (h == 1)
            {
                player.position = new Vector3(player.position.x + hTeleDist, player.position.y + vTeleDist, player.position.z);
            } else if (h == -1)
            {
                player.position = new Vector3(player.position.x - hTeleDist, player.position.y + vTeleDist, player.position.z);
            } else
            {
                player.position = new Vector3(player.position.x, player.position.y + vTeleDist, player.position.z);
            }
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Ground")
        {
            isGrounded = true;
            canTeleport = true;
        }
        if (collision.gameObject.tag == "Wall")
        {
            print("You hit a wall!");
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.tag == "Ground")
        {
            isGrounded = false;
        }
    }
}
