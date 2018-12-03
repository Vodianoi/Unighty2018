using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zombie : Entity
{

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "enemyBullet")
        {
            Bullet bulletScript = collision.gameObject.GetComponent<Bullet>();
            
            GameObject.Destroy(collision.gameObject);
        }
    }
}
