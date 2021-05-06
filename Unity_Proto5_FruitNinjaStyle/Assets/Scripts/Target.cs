using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour
{
    public float minSpeed = 12;
    public float maxSpeed = 16;
    public float maxTorque = 10;
    public float xRange = 4;
    public float ySpawnPos = -6;
    Rigidbody targetRb;
    private void Start() {
        targetRb = GetComponent<Rigidbody>();
        targetRb.AddForce(RandomForce() , ForceMode.Impulse );
        targetRb.AddTorque(RandomTorque(), RandomTorque(), RandomTorque(), ForceMode.Impulse);
        transform.position = RandomSpawnPos();
    }

    private void OnMouseDown() {
        Destroy(gameObject);
    }

    Vector3 RandomForce(){
        return Vector3.up * Random.Range(minSpeed,maxSpeed);
    }
    Vector3 RandomSpawnPos(){
        return new  Vector3(Random.Range(-xRange,xRange), ySpawnPos);
    }
    float RandomTorque(){
        return Random.Range(-maxTorque,maxTorque);
    }

}
