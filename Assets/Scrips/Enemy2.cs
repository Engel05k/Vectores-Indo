using UnityEngine;
using UnityEngine.AI;

public class Enemy2 : MonoBehaviour
{
    public GameObject obejeto1;
    public GameObject obejeto2;

    public NavMeshAgent agente;



    void Start()
    {
        
    }

    void Update()
    {
        EnemyNavMesh();

    }

    private void EnemyNavMesh()
    {
        agente.SetDestination(obejeto1.transform.position);
    }
}