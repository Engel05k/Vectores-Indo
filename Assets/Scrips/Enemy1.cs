using UnityEngine;

public class Enemy1 : MonoBehaviour
{
    public GameObject obejeto1;
    public GameObject obejeto2;

    public float dist;
    public float velocity = 1f;
    


    void Start()
    {
        
    }

    void Update()
    {
        LookQuaternions();
    }

    private void LookQuaternions()
    {
        Quaternion rot = Quaternion.LookRotation(obejeto1.transform.position-obejeto2.transform.position);
        obejeto2.transform.rotation = rot;
    }
}