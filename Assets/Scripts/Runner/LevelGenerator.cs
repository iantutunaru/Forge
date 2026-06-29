using UnityEngine;

namespace Runner
{
    public class LevelGenerator : MonoBehaviour
    {
        [SerializeField] private GameObject chunkPrefab;
        [SerializeField] private int startingChunksAmount = 12;
        [SerializeField] private Transform chunksParent;
        [SerializeField] private float chunkLength = 10f;

        private void Start()
        {
            for (var i = 0; i < startingChunksAmount; i++)
            {
                float spawnPositionZ;

                if (i == 0)
                {
                    spawnPositionZ = transform.position.z;
                }
                else
                {
                    spawnPositionZ = transform.position.z + (i * chunkLength);
                }
                
                var chunkSpawnPosition = new Vector3(transform.position.x, transform.position.y, spawnPositionZ);
                
                Instantiate(chunkPrefab, chunkSpawnPosition, Quaternion.identity, chunksParent);
            }
        }
    }
}
