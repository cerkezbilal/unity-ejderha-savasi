using EjderhaSavasi.Pools;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace EjderhaSavasi.Controllers
{
    public class RedDragonController : EnemyController
    {
        public override void SetEnemyPool()
        {
            RedDragonPool.Instance.Set(this);
        }
    }

}
