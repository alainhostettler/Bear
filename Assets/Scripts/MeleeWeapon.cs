﻿using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class MeleeWeapon : Weapon
{
    [SerializeField]
    protected float _knockBackImpact;


    public override void Attack()
    {
        var destroyed = new List<Creature>();
        foreach (var entity in EntitiesInAttackRange)
        {
            entity.ApplyDamage(_baseDamage);
            entity.KnockBack(Vector2.right * transform.parent.localScale.x * _knockBackImpact);
        }

        base.Attack();
    }
}
