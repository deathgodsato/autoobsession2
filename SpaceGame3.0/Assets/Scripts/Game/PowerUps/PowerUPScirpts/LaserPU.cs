﻿using UnityEngine;
using System.Collections;

public class LaserPU : PowerUps
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

            GetComponent<Rigidbody>().velocity = transform.up * m_DropSpeed;
        }
    }

    public override void ItemAffect(GameObject player)
    {
        //change bolt to laser for 30 seconds
        //damage = 20 + 25% per player damage level
        //return to bolt after timer expires
        throw new System.NotImplementedException();
    }
    
    public override void UseItem(GameObject player)
    {
        throw new System.NotImplementedException();
    }
    
}
