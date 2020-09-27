using UnityEngine;

public class OnTouchSpawnObjects : MonoBehaviour {

    public GameObject SpawnType1;
    private Vector3 spawnPosition;
    public GameObject SpawnerPos;

    void OnMouseDown() {
        spawnPosition = SpawnerPos.transform.position;

        Instantiate(SpawnType1);
        SpawnType1.transform.position = spawnPosition;
    }
}
