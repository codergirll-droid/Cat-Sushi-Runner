using UnityEngine;

public class camFollow : MonoBehaviour
{
    GameObject target;
    public Vector3 offset;


    private void Start()
    {
        target = GameObject.FindGameObjectWithTag("Player");
    }

    private void FixedUpdate()
    {
        transform.position = new Vector3(transform.position.x, transform.position.y, target.transform.position.z) + offset;

    }

}
