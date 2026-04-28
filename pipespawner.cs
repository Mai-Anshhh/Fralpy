using UnityEngine;

public class pipespawner : MonoBehaviour
{

    public GameObject pipe;
    public float spawnRate = 2;
    private float timer = 0;
    public float hieghtoffset = 10;

    void Start()
    {
        spawnpipe();
    }

    void Update()
    {
        if (timer < spawnRate)
        {
            timer += Time.deltaTime;
        }
        else
        {
            spawnpipe();
            timer = 0;
        }
        
    }

    void spawnpipe()
    {
        float lowestpoint = transform.position.y - hieghtoffset;
        float highestpoint = transform.position.y + hieghtoffset;

        Instantiate(pipe, new Vector3(transform.position.x, Random.Range(lowestpoint, highestpoint), 0), transform.rotation);
    }
}
