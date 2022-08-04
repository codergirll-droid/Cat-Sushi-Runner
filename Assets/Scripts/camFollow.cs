using UnityEngine;

public class camFollow : MonoBehaviour
{
    public GameObject target;
    public Vector3 offset;

    private void FixedUpdate()
    {
        transform.position = new Vector3(transform.position.x, transform.position.y, target.transform.position.z) + offset;

    }

}
