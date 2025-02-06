using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float Speed = 5f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 pos = transform.position;

        pos.x += Input.GetAxisRaw("Horizontal") * Speed * Time.deltaTime;
        pos.y += Input.GetAxisRaw("Vertical") * Speed * Time.deltaTime;

        transform.position = pos;
    }
}
