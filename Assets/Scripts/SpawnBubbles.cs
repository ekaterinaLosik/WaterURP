using UnityEngine;

public class SpawnBubbles : MonoBehaviour {
        public GameObject BubbleType;

        private Vector3 spawnPosition;

        public float maxSpawnRateInSeconds;

        void Start() {
                StartBubbleSpawn();
        }

        public void StartBubbleSpawn() {
                Invoke("SpawnBubble", 0.5f);
        }

        void SpawnBubble() {
                spawnPosition.x = transform.position.x + Random.Range(-1, 3);
                spawnPosition.y = transform.position.y + Random.Range(-1, 3);
                spawnPosition.z = transform.position.z + Random.Range(-1, 3);

                GameObject newBubble = Instantiate(BubbleType);
                
                newBubble.transform.parent = transform;
                newBubble.transform.position = new Vector3(spawnPosition.x, spawnPosition.y, spawnPosition.z);

                NextBubbleSpawn();
        }

        void NextBubbleSpawn() {
                float spawnInNSeconds;
                spawnInNSeconds = Random.Range(1f, maxSpawnRateInSeconds);
                Invoke("SpawnBubble", spawnInNSeconds);
        }
}