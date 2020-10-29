using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnBall : MonoBehaviour
{
    public GameObject ballPrefab;

    public void SpawnBallPrefab()
    {
        Vector3 position = new Vector3(this.transform.position.x, this.transform.position.y + 0.2f, this.transform.position.z);

        GameObject spawnBall = Instantiate(ballPrefab, position, Quaternion.identity);
    }
}
