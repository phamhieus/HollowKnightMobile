using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : Trap
{
    public Vector2 direction;
    public int damageToPlayer;
    public float movingSpeed;
    public float destroyTime;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        string layerName = LayerMask.LayerToName(collision.collider.gameObject.layer);

        if (layerName == "Player")
        {
            PlayerController playerController = collision.collider.GetComponent<PlayerController>();
            playerController.Hurt(damageToPlayer);
        }
    }

    public override void Trigger()
    {
        Vector2 newVelocity = direction.normalized * movingSpeed;
        gameObject.GetComponent<Rigidbody2D>().velocity = newVelocity;

        StartCoroutine(DestroyCoroutine(destroyTime));
    }

    private IEnumerator DestroyCoroutine(float delay)
    {
        yield return new WaitForSeconds(delay);
        Destroy(this);
    }
}
