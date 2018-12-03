using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour {

    public enum WeaponType
    {
        Unarmed,
        FightFist,
        Sniper,
        Repeller,
        HealGun,
        Rifle
    }

    protected WeaponType m_weaponType
    {
        get { return m_weaponType; }
        set { m_weaponType = value; }
    }
    protected float m_damage
    {
        get { return m_damage; }
        set { m_damage = value; }
    }
    protected float m_attackSpeed
    {
        get { return m_attackSpeed; }
        set { m_attackSpeed = value; }
    }
    protected float m_range
    {
        get { return m_range; }
        set { m_range = value; }
    }

    public Weapon(WeaponType type, float damage, float attackSpeed, float range)
    {
        m_weaponType = type;
        m_damage = damage;
        m_attackSpeed = attackSpeed;
        m_range = range;
    }

    public Weapon(Weapon w)
    {
        m_weaponType = w.m_weaponType;
        m_damage = w.m_damage;
        m_attackSpeed = w.m_attackSpeed;
        m_range = w.m_range;
    }

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
