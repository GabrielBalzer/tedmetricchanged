using System;
using UnityEngine;

public class rig : Singleton<rig>
{

    [SerializeField]
    private Vector3 velocity;

    private void FixedUpdate()
    {
        transform.position += (velocity * Time.deltaTime);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        TedPlayer ted = new TedPlayer();
        if (collision.transform.name == "Player")
        {
            Destroy(gameObject);
            return;
        }
        Platform01 platform01 = collision.collider.GetComponent<Platform01>();
        if (platform01 != null)
        {
            return;
        }

        if ((collision.contacts[0].normal.y < -0.5) && (collision.transform.name == "Player")) // only player can be able to destroy game object
        {
            Destroy(gameObject);
        }
    }
}
