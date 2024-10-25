using System.Security.Cryptography.X509Certificates;
using UnityEngine;

public class PipeSpawner : MonoBehaviour
{
    public GameObject prefab;

    public float spawnRate = 1f;
    public float minHeight = -1f;
    public float maxHeight = 1f;

    private void OnEnable()
    {
        InvokeRepeating(nameof(SpawnPipes), spawnRate, spawnRate);
    }

    private void OnDisable()
    {
        CancelInvoke(nameof(SpawnPipes));
    }
    private void SpawnPipes()
    {
        GameObject pipes = Instantiate(prefab, transform.position, Quaternion.identity);
        pipes.transform.position += Vector3.up * Random.Range(minHeight, maxHeight);
    }
}
