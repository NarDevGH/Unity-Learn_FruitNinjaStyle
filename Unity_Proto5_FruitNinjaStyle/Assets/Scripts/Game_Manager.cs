using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game_Manager : MonoBehaviour
{
    public List<GameObject> targets;
    public float spawnRate = 1.0f;

    private void Start() {
        StartCoroutine( SpawnTarget() );
    }

    IEnumerator SpawnTarget(){
        while(true){
            yield return new WaitForSeconds(spawnRate);
            int index = Random.Range(0,targets.Count);
            Instantiate(targets[index]);
        }
    }
}
