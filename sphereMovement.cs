using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sphereMovement : MonoBehaviour
{
    [SerializeField] float speed = 10f;
    bool canScale = true;
    private Vector3 move = new Vector3(-0.1f, 0f, 0f);
    private Vector3 scale = new Vector3(1, 1, 1);
    SpawnerManager spawner;

    private void Awake()
    {
        spawner = GetComponent<SpawnerManager>();
    }

    // Update is called once per frame
    void Update()
    {
        if (canScale)
            if (Input.GetKey(KeyCode.F))
                transform.localScale += scale * Time.deltaTime;

        if (Input.GetKeyUp(KeyCode.F))
            canScale = false;

        if (!canScale)
            transform.position += move * speed * Time.deltaTime;
    }
}
