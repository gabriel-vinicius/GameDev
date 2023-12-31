using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Parallax : MonoBehaviour
{
    private float lenght, start_pos;
    public GameObject cam;
    public float parallaxEffect;

    void Start()
    {
        start_pos = transform.position.x;
        lenght = GetComponent<SpriteRenderer>().bounds.size.x;

    }
    void FixedUpdate()
    {
        float dist = (cam.transform.position.x * parallaxEffect);

        transform.position = new Vector3(start_pos + dist, transform.position.y, transform.position.z);

    }
}
