using System;
using UnityEngine;

    public abstract class EnemyFactory
    {
        public abstract Sphere CreateSphereEnemy();
        public abstract Cube CreateCubeEnemy();
        public abstract Capsule CreateCapsuleEnemy();

        internal IEnemy CreateEnemy(GameObject enemyPrefab)
        {
            throw new NotImplementedException();
        }
    }