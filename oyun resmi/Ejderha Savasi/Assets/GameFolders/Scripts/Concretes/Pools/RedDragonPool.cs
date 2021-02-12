using EjderhaSavasi.Abstracts.Pools;
using EjderhaSavasi.Controllers;
using System.Collections;
using UnityEngine;

namespace EjderhaSavasi.Pools
{
    public class RedDragonPool : GenericPool<RedDragonController>
    {
        public static RedDragonPool Instance {get; private set;}

        public override void ResetAllObjects()
        {
            foreach (RedDragonController child in GetComponentsInChildren<RedDragonController>())
            {
                if (!child.gameObject.activeSelf) continue;

                child.KillGameObject();
            }
        }

        protected override void SingeltonObject()
        {
            if(Instance == null)
            {
                Instance = this;
                DontDestroyOnLoad(this.gameObject);

            }
            else
            {
                Destroy(this.gameObject);
            }
        }
    }
}

