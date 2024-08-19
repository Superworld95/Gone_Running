using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pooling : MonoBehaviour
{
    public Dictionary<string, Queue<GameObject>> poolDictionary;
    [System.Serializable]
    public class Pool
    {
        public string tag;
        public GameObject prefab;
        public int size;
    }
    public List<Pool> pools;
    // Start is called before the first frame update
    void Start()
    {
        poolDictionary = new Dictionary<string, Queue<GameObject>>();
        foreach (Pool pool in pools)
        {
            Queue<GameObject> objectPool = new Queue<GameObject>();
            for (int i = 0; i < pool.size; i++)
            {
                GameObject obj = Instantiate(pool.prefab);
                obj.SetActive(false);
                objectPool.Enqueue(obj);
            }
            //poolDictionary.Add(pool.tag, objectPool);
        }
    }
    public void SpawnFromPool(string tag, Vector3 position, Quaternion rotation)
    {
        GameObject objToSpawn = poolDictionary[tag].Dequeue();
        objToSpawn.SetActive(true);
        objToSpawn.transform.position = position;
        objToSpawn.transform.rotation = rotation;
        poolDictionary[tag].Enqueue(objToSpawn);
    }

    public List<Pool> pool;
    public static Pooling Instance;

    private void OnAwake()
    {
        //Something is missing.
    }


    /* Code example.
     * public void SpawnThing() {
     * ObjectPooler.Instance.SpawnFromPool("Square",transform.position,transform.rotation);
     * }
     *
     */


    // Update is called once per frame
    void Update()
    {
        
    }
}
