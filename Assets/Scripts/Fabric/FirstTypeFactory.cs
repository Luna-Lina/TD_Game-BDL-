using UnityEngine;

    public class FirstTypeFactory : EnemyFactory
    {
        public override Capsule CreateCapsuleEnemy()
        {
            var prefab = Resources.Load<GameObject>("Prefab/EnemyCapsule");
            var go = GameObject.Instantiate(prefab);
            var capsule = go.GetComponent<Enemy>();
            var enemyMovement = go.GetComponent<EnemyMovement>();
            return (Capsule)capsule;
        }

        public override Cube CreateCubeEnemy()
        {
            var prefab = Resources.Load<GameObject>("Prefab/EnemyCube");
            var go = GameObject.Instantiate(prefab);
            var cube = go.GetComponent<Enemy>();
            var enemyMovement = go.GetComponent<EnemyMovement>();
            return (Cube)cube;
        }

        public override Sphere CreateSphereEnemy()
        {
            var prefab = Resources.Load<GameObject>("Prefab/EnemySphere");
            var go = GameObject.Instantiate(prefab);
            var sphere = go.GetComponent<Enemy>();
            var enemyMovement = go.GetComponent<EnemyMovement>();
            return (Sphere)sphere;
        }
    }