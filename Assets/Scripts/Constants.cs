using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class Constants {

    public static Weapon m_weaponUnarmed = new Weapon(Weapon.WeaponType.Unarmed, 5, 2, 1); //dps: 10
    public static Weapon m_weaponRifle = new Weapon(Weapon.WeaponType.Rifle, 8, 4, 6); //dps: 32
    public static Weapon m_weaponSniper = new Weapon(Weapon.WeaponType.Sniper, 80, 0.5f, 10); //dps: 40
    public static Weapon m_weaponFightFist = new Weapon(Weapon.WeaponType.FightFist, 22.5f, 2, 1); //dps: 45
    public static Weapon m_weaponRepeller = new Weapon(Weapon.WeaponType.Repeller, 6, 1, 4); // repoussage par seconde: 6
    public static Weapon m_weaponHealGun = new Weapon(Weapon.WeaponType.HealGun, 5, 6, 1); //hps: 30
    
}
