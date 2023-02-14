using UnityEngine;

public class DistanceCalculator : MonoBehaviour
{
    public GameObject obejeto1;
    public GameObject obejeto2;

    public float dist;


    void Start()
    {
        
    }

    void Update()
    {
        dist = Vector3.Distance(a:obejeto1.transform.position,b:obejeto2.transform.position);
        Debug.Log(dist);
    }
}
