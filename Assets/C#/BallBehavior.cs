using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallBehavior : MonoBehaviour
{
    public float lifeTime;
    public float moveSpeed;

    private float elapsedTime = 0f;
    private GameObject target;
    
    // Start is called before the first frame update
    void Start()
    {
        elapsedTime = 0;
        target = GameObject.Find("target");
        gameObject.transform.LookAt(target.transform.position);
    }

    // Update is called once per frame
    void Update()
    {
        elapsedTime += Time.deltaTime;

        if (elapsedTime >= lifeTime || Vector3.Distance(target.transform.position, gameObject.transform.position) < 0.1f)
        {
            Destroy(gameObject);
        }
        
        gameObject.transform.position += gameObject.transform.forward * Time.deltaTime * moveSpeed;
        gameObject.transform.localScale *= (lifeTime - elapsedTime) / lifeTime;

        int rand = Random.Range(0, 100);
        if (rand < 5)
        {
            lifeTime = Random.Range(5.0f, 20.0f);
        }
        
    }

    void OnCollisionStay(Collision col)
    {
        LineRenderer line = gameObject.GetComponent<LineRenderer>();
        
        if (col.gameObject.CompareTag("Ball"))
        {
            Vector3[] positions = new Vector3[]
            {
                gameObject.transform.position,
                col.gameObject.transform.position
            };
            
            line.SetPositions(positions);
            line.startWidth = 0.1f;
            line.endWidth = 0.1f;
        }
        else
        {
            Destroy(line);
        }
    }
}
