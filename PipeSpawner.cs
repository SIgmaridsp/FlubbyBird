using UnityEngine;

public class PipeSpawner : MonoBehaviour
{
    [SerializeField] private GameObject pipePrefab;
    [SerializeField] private float interval = 1.5f;
    [SerializeField] private float heightRange = 3f;

    void Start()
    {
        Debug.Log("PipeSpawner started. Prefab is: "
                  + (pipePrefab == null ? "NULL — drag the Pipe prefab into the slot!" : pipePrefab.name));

        if (pipePrefab == null) return;

        InvokeRepeating(nameof(Spawn), interval, interval);
    }

    void Spawn()
    {
        float y = Random.Range(-heightRange, heightRange);
        Vector3 spawnPos = new Vector3(8f, y, 0f);
        Instantiate(pipePrefab, spawnPos, Quaternion.identity);
        Debug.Log("Spawned a pipe at y=" + y);
    }
}