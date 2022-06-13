using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class BallBehavior : MonoBehaviour
{
    public float lifeTime;
    public float moveSpeed;

    private float elapsedTime = 0f;
    private GameObject target;

    private LineRenderer lineRenderer;
    private int rand;

    // Start is called before the first frame update
    void Start()
    {
        elapsedTime = 0;
        target = GameObject.Find("target");
        gameObject.transform.LookAt(target.transform.position);

        lineRenderer = gameObject.GetComponent<LineRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        elapsedTime += Time.deltaTime;

        if (elapsedTime >= lifeTime || Vector3.Distance(target.transform.position, gameObject.transform.position) < 0.1f || transform.localScale.magnitude <= 0.1f)
        {
            Destroy(gameObject);
        }
        
        gameObject.transform.position += gameObject.transform.forward * Time.deltaTime * moveSpeed;
        //gameObject.transform.localScale *= (lifeTime - elapsedTime) / lifeTime;

        rand = Random.Range(0, 100);
        if (rand < 5)
        {
            lifeTime = Random.Range(5.0f, 20.0f);
        }


        GameObject closest = FindClosestBall();
        if (closest != null)
        {
            Vector3[] positions = new Vector3[]
                    {
                        gameObject.transform.position,
                        closest.transform.position
                    };
                    
            lineRenderer.SetPositions(positions);
            lineRenderer.startWidth = 0.02f;
            lineRenderer.endWidth = 0.02f;
            
        }
    }
    
    GameObject FindClosestBall()
    {
        GameObject[] gos;
        gos = GameObject.FindGameObjectsWithTag("Ball");
        GameObject closest = null;
        float distance = Mathf.Infinity;
        Vector3 position = transform.position;
        foreach (GameObject go in gos)
        {
            Vector3 diff = go.transform.position - position;
            float curDistance = diff.sqrMagnitude;
            if (curDistance < distance && curDistance != 0f)
            {
                closest = go;
                distance = curDistance;
            }
        }
        return closest;
    }
}
