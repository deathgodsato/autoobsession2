﻿using UnityEngine;
using System.Collections;

public class MissileBatteryPU : PowerUps
{
    public override void Start()
    {
        m_IsStorable = true;
    }
    public override void Update()
    {
        if (this.isActiveAndEnabled)
        {
            Vector3 movement = new Vector3(0, m_DropSpeed, 0);

            GetComponent<Rigidbody>().velocity = movement;
        }
    }

    //launch 10 small missiles with tracking
    public override void ItemAffect(GameObject player)
    {
        Debug.Log("Used a MissileBattery");
    }

    public override void UseItem(GameObject player)
    {
        ItemAffect(player);
    }
    //damage = 10/missile + 25% per player damage level
}
