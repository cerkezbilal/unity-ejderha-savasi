using EjderhaSavasi.Abstracts.Spawners;
using EjderhaSavasi.Controllers;
using EjderhaSavasi.Movements;
using EjderhaSavasi.Pools;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace EjderhaSavasi.Spawners
{
    public class ObsticleSpawner : BaseSpawner
    {
  
        protected override void Spawn()
        {
            EnemyController poolEnemy = ObsticlePool.Instance.Get();
            poolEnemy.transform.position = this.transform.position;
            poolEnemy.gameObject.SetActive(true);
        }
    }
}

