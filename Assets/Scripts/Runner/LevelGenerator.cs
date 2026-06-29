using UnityEngine;

namespace Runner
{
    public class LevelGenerator : MonoBehaviour
    {
        [SerializeField] private GameObject chunkPrefab;
        [SerializeField] private int startingChunksAmount = 12;
        [SerializeField] private Transform chunksParent;
        [SerializeField] private float chunkLength = 10f;

        void Start()
        {
            for (int i = 0; i < startingChunksAmount; i++)
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
                
                Vector3 chunkSpawnPosition = new Vector3(transform.position.x, transform.position.y, spawnPositionZ);
                
                Instantiate(chunkPrefab, chunkSpawnPosition, Quaternion.identity, chunksParent);
            }
        }
    }
}
