using EjderhaSavasi.Abstracts.Controllers;
using EjderhaSavasi.Pools;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace EjderhaSavasi.Controllers
{
    public abstract class EnemyController : LifeCycleController
    {
        public override void KillGameObject()
        {
            _currentTime = 0f;
            SetEnemyPool();
        }

        public abstract void SetEnemyPool();
    }
}

