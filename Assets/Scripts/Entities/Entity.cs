using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Entity : MonoBehaviour {

    protected float m_hp
    {
        get { return m_hp; }
        set { m_hp = value; }
    }
    protected float m_moveSpeed
    {
        get { return m_moveSpeed; }
        set { m_moveSpeed = value; }
    }
    protected Weapon m_weapon
    {
        get { return m_weapon; }
        set { m_weapon = value; }
    }
    

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
