using System.Numerics;

    public interface IEnemy
    {
        public void TakeDamage(float dmg)
        {
            throw new System.NotImplementedException();
        }

        void Spawn(Vector3 spawnPos);
        void Move();
    }