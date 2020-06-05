using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyfollow : MonoBehaviour
{

    public float speed;
    public float stopingDistance;

    private float timeBtwShots;
    public float startTimebtwShots;

    public GameObject projectile;
    private Transform player;

    private Transform target;

    // Start is called before the first frame update
    void Start()
    {
        target = GameObject.FindGameObjectWithTag("player").GetComponent<Transform>();
        timeBtwShots = startTimebtwShots;
    }

    // Update is called once per frame
    void Update()
    {
        if(Vector2.Distance(transform.position, target.position) > stopingDistance)
        {
            transform.position = Vector2.MoveTowards(transform.position, target.position, speed * Time.deltaTime);
        }


        if(timeBtwShots <= 0)
        {

            Instantiate(projectile, transform.position, Quaternion.identity);
            timeBtwShots = startTimebtwShots;

        }else
        {
            timeBtwShots -= Time.deltaTime;
        }
    }
}
