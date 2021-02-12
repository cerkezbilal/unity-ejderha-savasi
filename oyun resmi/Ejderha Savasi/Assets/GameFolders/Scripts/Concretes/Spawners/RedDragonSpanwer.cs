using EjderhaSavasi.Abstracts.Spawners;
using EjderhaSavasi.Controllers;
using EjderhaSavasi.Pools;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace EjderhaSavasi.Spawners
{
    public class RedDragonSpanwer : BaseSpawner
    {

        protected override void Spawn()
        {
            EnemyController newEnemy = RedDragonPool.Instance.Get();
            newEnemy.transform.position = transform.position;
            newEnemy.gameObject.SetActive(true);
        }
    }
}


