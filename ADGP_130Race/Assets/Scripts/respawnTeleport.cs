using UnityEngine;
using System.Collections;

public class respawnTeleport : MonoBehaviour {

    public Transform destination;

    void OnTriggerEnter(Collider other)
    {
        other.transform.position = destination.position;
    }
}
