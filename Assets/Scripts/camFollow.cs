using UnityEngine;

public class camFollow : MonoBehaviour
{
    GameObject target;
    public Vector3 offset;
    bool shouldFollow = true;
    bool selectedPos = false;
    public bool changePos = false;
    public Vector3 pos1;
    public Vector3 pos2;

    private void Start()
    {
        target = GameObject.FindGameObjectWithTag("Player");
    }

    private void FixedUpdate()
    {
        if (shouldFollow)
            transform.position = new Vector3(transform.position.x, transform.position.y, target.transform.position.z) + offset;


    }


    private void Update()
    {
        shouldFollow = !Player.Instance.win;
        if(!shouldFollow && !selectedPos)
        {
            pos1 = new Vector3(target.transform.position.x + 2f, target.transform.position.y + 0.5f, target.transform.position.z + 3);
            //pos1 = new Vector3(target.transform.position.x + 3f, target.transform.position.y + 0.5f, target.transform.position.z);
            pos2 = new Vector3(target.transform.position.x, target.transform.position.y + 0.5f, target.transform.position.z + 3);
            selectedPos = true;
        }

        if(!shouldFollow && transform.position != pos1 && !changePos)
        {
            transform.position = Vector3.Lerp(transform.position, pos1 , 0.05f);
            transform.LookAt(target.transform);
        }
        /*
        else if (changePos && transform.position != pos2)
        {
            transform.position = Vector3.Lerp(transform.position, pos2, 0.05f);
            transform.LookAt(target.transform);
        }

        if (Vector3.Distance(transform.position, pos1) < 0.1f)
        {
            changePos = true;
        }
        */


    }

}
