using UnityEngine;

public class Enemyspot : MonoBehaviour
{
    public Transform t, thePlayer;
     

    // Start is called before the first frame update
    void Start()
    {
        t = GetComponent<Transform>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if ((t.position.z - thePlayer.position.z <= 130) && (t.position.z - thePlayer.position.z >= 0))
        {
            switch (t.name)
            {
                case "Enemy Spot A":
                    Pooling.Instance.SpawnFromPool("SidetoSideEnemy", t.transform.position, t.transform.rotation, t);
                    break;
                case "Enemy Spot B":
                    Pooling.Instance.SpawnFromPool("JumperEnemy", t.transform.position, t.transform.rotation, t);
                    break;
                case "Enemy Spot C":
                    Pooling.Instance.SpawnFromPool("JumpwhenEnemy", t.transform.position, t.transform.rotation, t);
                    break;
                case "Enemy Spot D":
                    Pooling.Instance.SpawnFromPool("SidetoSideEnemy", t.transform.position, t.transform.rotation, t);
                    break;
                case "Enemy Spot E":
                    Pooling.Instance.SpawnFromPool("JumpwhenEnemy", t.transform.position, t.transform.rotation, t);
                    break;
                case "Enemy Spot F":
                    Pooling.Instance.SpawnFromPool("SideandJump", t.transform.position, t.transform.rotation, t);
                    break;

                case "Enemy Spot G":
                    Pooling.Instance.SpawnFromPool("SidetoSideEnemy", t.transform.position, t.transform.rotation, t);
                    break;
                case "Enemy Spot H":
                    Pooling.Instance.SpawnFromPool("JumperEnemy", t.transform.position, t.transform.rotation, t);
                    break;
                case "Enemy Spot I":
                    Pooling.Instance.SpawnFromPool("JumpwhenEnemy", t.transform.position, t.transform.rotation, t);
                    break;
                case "Enemy Spot J":
                    Pooling.Instance.SpawnFromPool("SidetoSideEnemy", t.transform.position, t.transform.rotation, t);
                    break;                
            }
        }
    }
    }

