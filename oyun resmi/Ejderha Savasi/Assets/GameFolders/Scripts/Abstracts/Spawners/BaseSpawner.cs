using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace EjderhaSavasi.Abstracts.Spawners
{
    public abstract class BaseSpawner : MonoBehaviour
    {
        [Range(2f, 5f)]
        [SerializeField] float maxSpawnTime = 3f;

        [Range(0.3f, 1.5f)]
        [SerializeField] float minSpawnTime = 1f;

        float _currenSpawnTime;
        float _timeBoundary;

        private void Start()
        {
            ResetTime();
        }

        private void Update()
        {
            _currenSpawnTime += Time.deltaTime;

            if (_currenSpawnTime > _timeBoundary)
            {
                Spawn();
                ResetTime();
            }
        }

        protected abstract void Spawn();
      

        private void ResetTime()
        {
            _currenSpawnTime = 0f;
            _timeBoundary = Random.Range(minSpawnTime, maxSpawnTime);
        }

    }
}

