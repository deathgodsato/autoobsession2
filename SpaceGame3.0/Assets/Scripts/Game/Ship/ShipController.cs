﻿using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ShipController : MonoBehaviour
{
    public ShipData m_Data;
    public Ship m_Ship;

    public GameObject m_Explosion;

    private int totalDamage_;

    public void FireWeapons(string collisionLayerName)
    {
        for (int i = 0; i < m_Data.m_WeaponState.Length; ++i)
        {
            if (m_Data.m_WeaponState[i].m_CooldownTimer <= 0.0f)
            {
                m_Data.m_Weapons[i].Fire(m_Data.m_WeaponState[i], gameObject, collisionLayerName);
            }
        }
    }

    public void ApplyDamage(GameObject ship, int damage)
    {
        totalDamage_ = damage * ship.GetComponent<Ship>().m_DamageModifier;

        m_Data.m_HP -= totalDamage_;

        if (m_Data.m_HP <= 0)
        {
            if (ship.tag == "Player")
            {
                //StopAllCoroutines();
                Camera.main.GetComponent<GameController>().SoftSave();
                //ship.GetComponent<SpawnPlayer>().m_Player.SetActive(false); 
                Destroy(ship);
                Camera.main.GetComponent<GameController>().Respawn();
                

            }

            if (ship.tag == "Enemy")
            {
                Camera.main.GetComponent<EnemySpawn>().m_RequiredKills -= 1;
                Camera.main.GetComponent<EnemySpawn>().m_ReqKillText.text = Camera.main.GetComponent<EnemySpawn>().m_RequiredKills.ToString();
                Camera.main.GetComponent<GameController>().m_Score += 100;
                Camera.main.GetComponent<GameController>().m_Salvage += 50 * ship.GetComponent<EnemyShip>().m_Tier;
                DropLoot();
                Destroy(gameObject);
            }
            Instantiate(m_Explosion, transform.position, transform.rotation);
        }
    }

    private void DropLoot()
    {
        //go through engines, drop if random number > mDropChance
        foreach (EngineData engine in m_Data.m_Engines)
        {
            if (Random.value >= Constants.DROP_CHANCE)
            {
                Debug.Log("You dropped an item from the engines");
            }
        }

        //go through weapons, drop if random number > mDropChance
        foreach (Weapon weapon in m_Data.m_Weapons)
        {
            if (Random.value >= Constants.DROP_CHANCE)
            {
                Debug.Log("You dropped an item from the Weapons");
            }
        }
    }
}
