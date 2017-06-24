using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUp : MonoBehaviour {

    void OnParticleCollision(GameObject other)
    {
        Destroy(gameObject);
    }
}
