using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;
using TMPro;
using Cinemachine;
using UnityEngine.SocialPlatforms;

public class Player : MonoBehaviour
{
    public Rigidbody player;
    public float forSpd = 2, spd = 2, jumpHeight = 2, hTeleDist = 2, vTeleDist = 2;
    float h, u, speedIncrease = 1, roundDistance = 800;
    [SerializeField] Runner _runner;
    [SerializeField] PlayerInput _playerInput;
    bool isJumping = false, isGrounded = false, canTeleport = false, isPaused = false;
    private Animator anim;
    public ParticleSystem dustTrail, jumpDust, portDust;
    public int stylePoints = 0, hp = 20, maxHp = 0, trueScore = 0, rounds = 0;
    public TMP_Text health, score, pause;
    public GameObject cam1, cam2, cam3;
    public AudioSource smoke, jump, defeat, hurt;
    bool gameOver = false;
    // Start is called before the first frame update
    void Start()
    {
        _runner = new Runner();
        _runner.Enable();
        player = GetComponent<Rigidbody>();
        anim = GetComponent<Animator>();
        smoke = GetComponent<AudioSource>();
        //jump = GetComponent<AudioSource>();
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
        switch (rounds%9)
        {
            case 0:
                cam1.SetActive(true);
                cam2.SetActive(false);
                cam3.SetActive(false);
                break;
            case 1:
                cam1.SetActive(true);
                cam2.SetActive(false);
                cam3.SetActive(false);
                break;
            case 2:
                cam1.SetActive(true);
                cam2.SetActive(false);
                cam3.SetActive(false);
                break;
            case 3:
                cam1.SetActive(false);
                cam2.SetActive(true);
                cam3.SetActive(false);
                break;
            case 4:
                cam1.SetActive(false);
                cam2.SetActive(true);
                cam3.SetActive(false);
                break;
            case 5:
                cam1.SetActive(false);
                cam2.SetActive(true);
                cam3.SetActive(false);
                break;
            case 6:
                cam1.SetActive(false);
                cam2.SetActive(false);
                cam3.SetActive(true);
                break;
            case 7:
                cam1.SetActive(false);
                cam2.SetActive(false);
                cam3.SetActive(true);
                break;
            case 8:
                cam1.SetActive(false);
                cam2.SetActive(false);
                cam3.SetActive(true);
                break;
            default:
                break;
        }
        if (rounds%3 == 2)
        {
            cam1.SetActive(false);
            cam2.SetActive(true);
            cam3.SetActive(false);
        }
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
            Debug.Log("Quit");
        }
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
            if (gameOver)
            {
                if (rounds > 0)
                {
                    score.text = "Rounds: " + (rounds + 1).ToString() + "\nFinal Score: " + Mathf.Floor((trueScore + player.position.z + stylePoints)).ToString();
                }
                else
                {
                    score.text = "Final Score: " + Mathf.Floor((trueScore + player.position.z + stylePoints)).ToString();
                }
                health.text = "Health: " + hp.ToString() + "/" + maxHp;
                pause.text = "GAME OVER!\n" + score.text +"\nPress Pause to restart";
            } else
            {
                pause.text = "PAUSED";
            }
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
        if (player.velocity.z < spd + speedIncrease)
        {
            player.velocity = new Vector3(player.velocity.x, player.velocity.y, 1 * (forSpd + speedIncrease));
        }
        h = _runner.Movement.Around.ReadValue<Vector2>().x;
        u = _runner.Movement.Around.ReadValue<Vector2>().y;
        if (!isPaused && isGrounded) { 
        if (u > 0)
        {
            speedIncrease++;
        } else if (u < 0)
        {
            speedIncrease--;
        }
        if (speedIncrease < 1)
        {
            speedIncrease = 1;
        }
        if (speedIncrease > 10)
        {
            speedIncrease = 10;
        }
        }
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

        isJumping = _runner.Jumping.Rise.WasPressedThisFrame();
        if (isJumping && isGrounded)
        {
            dustTrail.Stop();
            jumpDust.Play();
            anim.SetTrigger("Jump");
            jump.Play(0);
            isGrounded = false;
            isJumping = false;
            player.velocity = new Vector3(player.velocity.x, jumpHeight, player.velocity.z);
            
        } else if (isJumping && !isGrounded && canTeleport)
        {
            portDust.Play();
            smoke.Play(0);
            
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
        if (player.position.z > roundDistance)
        {
            trueScore += ((int)roundDistance);
            rounds++;
            player.position = new Vector3(0, player.position.y, player.position.z - roundDistance);
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
            hp = 0;
        } else if (collision.gameObject.CompareTag("Wall")) {
            isGrounded = true;
            dustTrail.Play();
            stylePoints++;
        }
        if (collision.gameObject.CompareTag("Enemy"))
        {
            hp--;
            hurt.Play(0);
        }
        if (hp <= 0 && !gameOver && !isPaused)
        {
            gameOver = true;
            isPaused = true;
            defeat.Play(0);
        } else if (hp <= 0 && gameOver && !isPaused)
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
