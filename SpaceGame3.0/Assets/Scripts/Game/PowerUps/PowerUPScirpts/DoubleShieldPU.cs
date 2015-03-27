﻿using UnityEngine;
using System.Collections;

public class DoubleShieldPU : PowerUps
{

    public override void Start()
    {
        m_IsStorable = false;
    }
    public override void Update()
    {
        if (this.isActiveAndEnabled)
        {
            Vector3 movement = new Vector3(0, m_DropSpeed, 0);

            GetComponent<Rigidbody>().velocity = transform.up * m_DropSpeed;
        }
    }

    public override void ItemAffect(GameObject player)
    {
        //if player has shields, set health of shields to double the max
        if(player.GetComponent<ShipData>().m_HasShield)
        {
            player.GetComponent<ShipData>().m_Shield = player.GetComponent<PlayerShip>().m_MaxShieldHP * 2;
        }
        //if player does not have shields, set shileds to true with double base hp
        else
        {
            player.GetComponent<ShipData>().m_HasShield = true;
            player.GetComponent<ShipData>().m_Shield = player.GetComponent<PlayerShip>().m_MaxShieldHP * 2;
        }
    }

    public override void UseItem(GameObject player)
    {
        ItemAffect(player);
    }
}