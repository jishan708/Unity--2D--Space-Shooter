using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject enemyPrefab;
    public Transform player;

    public float minSpawnDistance = 5f;
    public float maxSpawnDistance = 8f;
    public float spawnInterval = 2f;
    void Start()
    {
        InvokeRepeating(nameof(spawnenemy), 1f, spawnInterval);
    }

    private void spawnenemy()
    {
        float RandomAngle = Random.Range(0f, 360f);

        // Angle to direction conversion
        Vector2 spawnDirection = new Vector2(Mathf.Cos(RandomAngle * Mathf.Deg2Rad), Mathf.Sin(RandomAngle * Mathf.Deg2Rad));

        float spawnDistance = Random.Range(minSpawnDistance, maxSpawnDistance);

        Vector2 spawnPosition = (Vector2)player.position + spawnDirection * spawnDistance;

        Instantiate(enemyPrefab, spawnPosition, Quaternion.identity);
    }
    

}
