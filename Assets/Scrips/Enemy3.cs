using UnityEngine;

public class Enemy3 : MonoBehaviour
{
    public Transform player;
    public float enemy1Speed = 2f;
    public float enemy2Speed = 3f;
    public float stoppingDistance = 2f;
    
    private EnemyType currentEnemyType;

    public enum EnemyType 
    {
        Enemy1,Enemy2
    }

    private void Update()
    {
        switch (currentEnemyType) 
        {
            case EnemyType.Enemy1:
                Vector3 direction1 = player.position - transform.position;
                direction1.y = 0;
                transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.LookRotation(direction1), enemy1Speed * Time.deltaTime);
                break;
            case EnemyType.Enemy2:
                Vector3 direction2 = player.position - transform.position;
                if (direction2.magnitude > stoppingDistance) 
                {
                    direction2.y = 0;
                    transform.position += direction2.normalized * enemy2Speed * Time.deltaTime;
                }
                break;
        }
    }

    public void SetEnemyType(EnemyType type) 
    {
        currentEnemyType = type;
    }
}
