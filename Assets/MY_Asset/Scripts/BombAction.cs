﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombAction : MonoBehaviour
{
    public GameObject bombEffect;
    private void OnCollisionEnter(Collision collision)
    {
        GameObject bombEffectGO = Instantiate(bombEffect);

        bombEffectGO.transform.position = transform.position;

        Destroy(collision.gameObject);
    }
}
