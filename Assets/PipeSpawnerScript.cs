using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawnerScript : MonoBehaviour
{
    public GameObject pipe;
    public float spawnerRateInSeconds = 3;
    public int hightOffset = 10;
    float timer = 0;

    // Start is called before the first frame update
    void Start()
    {
        SpawnPipe();
    }

    // Update is called once per frame
    async void Update()
    {
        if (timer > spawnerRateInSeconds) {
            timer = 0;
            SpawnPipe();
        }
        else {
            timer += Time.deltaTime;
        }
    }

    void SpawnPipe() {
        var lowestPoint = transform.position.y - hightOffset;
        var highestPoint = transform.position.y + hightOffset;

        var x = transform.position.x;
        var y = Random.Range(lowestPoint, hightOffset);
        var z = 0;

        var position = new Vector3(x, y, z);

        Instantiate(pipe, position, transform.rotation);
    }
}
