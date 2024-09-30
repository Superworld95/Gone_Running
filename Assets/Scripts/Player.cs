using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;
using TMPro;

public class Player : MonoBehaviour
{
    public Rigidbody player;
    public float forSpd = 2, spd = 2, jumpHeight = 2, hTeleDist = 2, vTeleDist = 2;
    float h;
    [SerializeField] Runner _runner;
    [SerializeField] PlayerInput _playerInput;
    bool isJumping = false, isGrounded = false, canTeleport = false, isPaused = false;
    private Animator anim;
    public ParticleSystem dustTrail, jumpDust, portDust;
    int stylePoints = 0, hp = 20, maxHp = 0, trueScore = 0, rounds = 0;
    public TMP_Text health, score, pause;
    // Start is called before the first frame update
    void Start()
    {
        _runner = new Runner();
        _runner.Enable();
        player = GetComponent<Rigidbody>();
        anim = GetComponent<Animator>();
        dustTrail.Stop();
        jumpDust.Stop();
        portDust.Stop();
        health.text = "1";
        score.text = "1";
        maxHp = hp;
    }

    // Update is called once per frame
    private void Update()
    {
        if (!isPaused && _runner.Paused.Pause.triggered)
        {
            isPaused = true;
        } else if (isPaused && _runner.Paused.Pause.triggered)
        {
            isPaused = false;
        }
        if (isPaused)
        {
            Time.timeScale = 0;
            pause.text = "PAUSED";
        }
        else
        {
            Time.timeScale = 1;
            pause.text = " ";
        }
    }
    void FixedUpdate()
    {
        
        if (health != null && score != null)
        {
            health.text = "Health: " + hp.ToString() + "/"+maxHp;
            if (rounds > 0)
            {
                score.text = "Round: " + (rounds+1).ToString() + "   Score: " + Mathf.Floor((trueScore + player.position.z + stylePoints)).ToString();
            } else
            {
                score.text = "Score: " + Mathf.Floor((trueScore + player.position.z + stylePoints)).ToString();
            }
        }
        if (player.velocity.z < spd)
        {
            player.velocity = Vector3.forward * forSpd;
        }
        h = _runner.Movement.Around.ReadValue<Vector2>().x;
        if (player.position.x > 9F)
        {
            player.velocity = new Vector3(-player.position.x*2 - 9F, player.velocity.y, player.velocity.z);
        } else if (player.position.x < -9F)
        {
            player.velocity = new Vector3(-player.position.x*2 - 9F, player.velocity.y, player.velocity.z);
        } else
        {
            player.velocity = new Vector3(h * spd, player.velocity.y, player.velocity.z);
        }

        isJumping = _runner.Jumping.Rise.inProgress;
        if (isJumping && isGrounded)
        {
            dustTrail.Stop();
            jumpDust.Play();
            anim.SetTrigger("Jump");
            isGrounded = false;
            isJumping = false;
            player.velocity = new Vector3(player.velocity.x, player.velocity.y + jumpHeight, player.velocity.z);
            
        } else if (isJumping && !isGrounded && canTeleport && player.velocity.y < 5f)
        {
            portDust.Play();
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
        if (player.position.z > 700)
        {
            trueScore += 700;
            rounds++;
            player.position = new Vector3(0, player.position.y, player.position.z - 700f);
            forSpd++;
            maxHp += 20;
            hp += 25;
        }
        if (hp > maxHp)
        {
            hp = maxHp;
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            canTeleport = true;
            anim.SetTrigger("Land");
            jumpDust.Stop();
            portDust.Stop();
        }
    }

    private void OnCollisionStay(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isGrounded = true;
            dustTrail.Play();
        }
        if (collision.gameObject.CompareTag("Wall") && player.velocity.z <= 1)
        {
            SceneManager.LoadScene("The Scene");
        } else if (collision.gameObject.CompareTag("Wall")) {
            isGrounded = true;
            dustTrail.Play();
            stylePoints++;
        }
        if (collision.gameObject.CompareTag("Enemy"))
        {
            hp--;
        }
        if (hp <= 0)
        {
            SceneManager.LoadScene("The Scene");
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isGrounded = false;
            dustTrail.Stop();
        }
    }
}
