using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerManager : MonoBehaviour
{
    private Vector3 spawnPos = new Vector3(2.5f, 1, 2);
    [SerializeField] private GameObject sphere;
    private GameObject createdSphere;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
            createSphere();

        if (Input.GetKeyUp(KeyCode.F))
            Invoke("destroySphere", 5f);
    }

    private void createSphere()
    {
        createdSphere = Instantiate(sphere, spawnPos, sphere.transform.rotation);
    }

    public void destroySphere()
    {
        Destroy(createdSphere);
    }
}
