using EjderhaSavasi.Pools;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace EjderhaSavasi.Controllers
{
    public class ObsticleController : EnemyController
    {
        public override void SetEnemyPool()
        {
            ObsticlePool.Instance.Set(this);
        }
    }

}
