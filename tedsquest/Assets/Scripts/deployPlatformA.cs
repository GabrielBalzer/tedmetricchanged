﻿using System.Collections;
using UnityEngine;

public class deployPlatformA : Singleton<deployPlatformA>
{
    public GameObject platformAPrefab;
    public float respawnTime = 1.0f;
    private Vector2 screenBounds;

    // Start is called before the first frame update
    private void Start()
    {
        screenBounds =
            Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));
        StartCoroutine(PlatformAWave());
    }

    private void spawnPlatformA()
    {
        var a = Instantiate(platformAPrefab);
        a.transform.position =
            new Vector2(screenBounds.x * -1, Random.Range((float)0.7, screenBounds.y / 2));
    }

    private IEnumerator PlatformAWave()
    {
        while (true)
        {
            yield return new WaitForSeconds(respawnTime);
            spawnPlatformA();
        }
    }
}