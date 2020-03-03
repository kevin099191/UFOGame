using System.Linq;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    private EMove[] enemys;
    private float[] enemysDistance;



    private void Move()
    {
        enemys = FindObjectsOfType<EMove>();
        enemysDistance = new float[enemys.Length];


        for (int i = 0; i < enemys.Length; i++)
        {

            enemysDistance[i] = Vector3.Distance(transform.position, enemys[i].transform.position);


        }



        float min = enemysDistance.Min();

        int index = enemysDistance.ToList().IndexOf(min);

        Vector3 posEnemy = enemys[index].transform.position;

        transform.position = new Vector3(posEnemy.x, posEnemy.y + 2, posEnemy.z);



    }

    private void FixedUpdate()
    {
        Move();
    }
}
