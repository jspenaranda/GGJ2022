using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class activateEnemy : MonoBehaviour
{
    Object bulletRef;
    private bool inside = false;
    public bool trigger;
    private bool isAlive = true;
    private Transform playerPos;
    //public GameEvent Lvl02EnemyShooting;
    void Start()
    {
        bulletRef = Resources.Load("Bullet");
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {

            trigger = true;
            inside = true;
            Invoke("ShootBullets", 1);

            //Debug.Log("EnemyActivated");
        }
    }


    private void OnTriggerExit2D(Collider2D other)
    {

        if (other.gameObject.tag == "Player")
        {
            trigger = false;
            inside = false;

            //Debug.Log("EnemyDisabled");
        }
    }


    public void ShootBullets()
    {
        if (isAlive == true)
        {
            GameObject bullet = (GameObject)Instantiate(bulletRef);
            bullet.transform.position = new Vector2(transform.position.x, transform.position.y + 2.5f);
            if (inside == true)
            {
                Invoke("ShootBullets", 2);
                //Lvl02EnemyShooting.Raise();
            }
        }
    }
}
