using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Collider))]
public class Character : Entity
{
    protected Collider m_collider;

    protected int m_coalNumber
    {
        get { return m_coalNumber; }
        set { m_coalNumber = value; }
    }
    protected int m_ironNumber
    {
        get { return m_ironNumber; }
        set { m_ironNumber = value; }
    }
    protected int m_copperNumber
    {
        get { return m_copperNumber; }
        set { m_copperNumber = value; }
    }
    protected int m_goldNumber
    {
        get { return m_goldNumber; }
        set { m_goldNumber = value; }
    }

    protected List<Skill> m_skill
    {
        get { return m_skill; }
        set { m_skill = value; }
    }

    protected float m_lifeSteal
    {
        get { return m_lifeSteal; }
        set { m_lifeSteal = value; }
    }

    // Use this for initialization
    void Start () {
        m_collider = GetComponent<Collider>();

        m_coalNumber = 0;
        m_ironNumber = 0;
        m_copperNumber = 0;
        m_goldNumber = 0;

        m_lifeSteal = 2;
        m_hp = 100;
        m_moveSpeed = 10;
        m_weapon = new Weapon(Constants.m_weaponUnarmed);
	}

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "enemyBullet")
        {

            GameObject.Destroy(collision.gameObject);
        }
    }

    // Update is called once per frame
    void Update () {
		
	}
}
