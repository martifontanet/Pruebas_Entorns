using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreeSpawner : MonoBehaviour
{
    public GameObject TreePrefab;

    public float SpawnRange_X;
    public float SpawnRange_Z;
    public float SpawnHeight;

    public int nSpawns = 3;
    public Vector3 pos;

    // Start is called before the first frame update
    void Start()
    {
        //SetRandomBallColor();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
            SpawnManyTrees(nSpawns);
    }

    private void SpawnManyTrees(int nSpawns)
    {
        for (int i = 0; i < nSpawns; i++)
        {
            float x = Random.Range(-50f, 50f);
            float z = Random.Range(-50f, 50f);
            SpawnOneTree(x,0,z);
        }
    }

    private void SpawnOneTree(float x, float y, float z = 0)
    {

        Vector3 pos = transform.position;
        pos.x = x;
        pos.y = y;
        pos.z = z;

        var rot = Quaternion.Euler(0, Random.Range(0f, 360f), 0);
        GameObject go = Instantiate(TreePrefab, pos, rot);
        go.transform.SetParent(transform);
    }

    
}
