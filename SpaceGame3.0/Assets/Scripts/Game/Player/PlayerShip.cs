﻿using UnityEngine;
using System.Collections;

public class PlayerShip : Ship 
{
    public PlayerController m_PController;
    public PlayerData m_PData;

    private int shieldUpgradeCounter_ = 1; //Amount of upgrades in the shield by the player
    private int engineUpgradeCounter_ = 1; //Amount of upgrades in the engines by the player
    private int damageUpgradeCounter_ = 1; //Amount of upgrades in the damage by the player
    private int healthUpgradeCounter_ = 1; //Amount of upgrades in the health by the player
    private int tierUpgradeCounter_ = 1; //Level of PlayerShip

    public int EngineLevel { get { return engineUpgradeCounter_; } set { engineUpgradeCounter_ = value; } }
    public int ShieldLevel { get { return shieldUpgradeCounter_; } set { shieldUpgradeCounter_ = value; } }
    public int DamageLevel { get { return damageUpgradeCounter_; } set { damageUpgradeCounter_ = value; } }
    public int HealthLevel { get { return healthUpgradeCounter_; } set { healthUpgradeCounter_ = value; } }
    public int Tier { get { return tierUpgradeCounter_; } set { tierUpgradeCounter_ = value; } }

    public void Start()
    {
        m_Tier = 1 * tierUpgradeCounter_;
        m_PController =  Camera.main.GetComponent<SpawnPlayer>().m_Player.GetComponent<PlayerController>();

        m_DamageModifier = DamageLevel;

        shieldUpgradeCounter_ = m_PData.m_ShieldLevel;
        healthUpgradeCounter_ = m_PData.m_HealthLevel;
        damageUpgradeCounter_ = m_PData.m_DamageLevel;
        engineUpgradeCounter_ = m_PData.m_EngineLevel;
        tierUpgradeCounter_ = m_PData.m_ShipTier;
    }
}
