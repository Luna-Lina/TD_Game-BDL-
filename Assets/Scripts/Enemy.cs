using System;
using UnityEngine;
using UnityEngine.UI;

    public class Enemy : MonoBehaviour
    {
        public event EventHandler<HealthEvent> OnHealthChange;
        public float startSpeed = 10f;
        [HideInInspector] public float speed;
        public float startHealth = 100;
        private float health;
        public int worth = 50;
        public GameObject deathEffect;
        [Header("Unity Stuff")] public Image healthBar;
        private bool isDead = false;
        private float maxHealth;
        public float MaxHealth => maxHealth;

        void Start()
        {
            speed = startSpeed;
            health = startHealth;
        }

        private void OnEnable()
        {
            maxHealth = health;
        }

        public void TakeDamage(float amount)
        {
            health -= amount;
            healthBar.fillAmount = health / startHealth;
            OnHealthChange?.Invoke(this, new HealthEvent { Health = health });

            if (OnHealthChange != null)
            {
                OnHealthChange(this, new HealthEvent { Health = health });
            }

            if (health <= 0 && !isDead)
            {
                Die();
            }
        }

        public void Slow(float pct)
        {
            speed = startSpeed * (1f - pct);
        }

        void Die()
        {
            isDead = true;
            PlayerStats.Money += worth;
            GameObject effect = (GameObject)Instantiate(deathEffect, transform.position, Quaternion.identity);
            Destroy(effect, 5f);
            WaveSpawner.EnemiesAlive--;
            Destroy(gameObject);
        }

        public void Spawn(System.Numerics.Vector3 spawnPos)
        {
            throw new NotImplementedException();
        }

        public void Move()
        {
            throw new NotImplementedException();
        }
    }