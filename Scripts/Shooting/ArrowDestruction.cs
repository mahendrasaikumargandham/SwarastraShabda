using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowDestruction : MonoBehaviour
{
    [SerializeField] float duration = 5f;
    void Start()
    {
        Destroy(gameObject, duration);
    }
}
