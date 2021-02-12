using EjderhaSavasi.Abstracts.Pools;
using EjderhaSavasi.Controllers;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace EjderhaSavasi.Pools
{
    public class ObsticlePool : GenericPool<ObsticleController>
    {
        public static ObsticlePool Instance { get; private set; }

        public override void ResetAllObjects()
        {
            foreach (ObsticleController child in GetComponentsInChildren<ObsticleController>())
            {
                if (!child.gameObject.activeSelf) continue;

                child.KillGameObject();
            }
        }
        protected override void SingeltonObject()
        {
            if (Instance == null)
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
