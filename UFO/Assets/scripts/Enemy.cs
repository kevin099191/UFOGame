using System.Linq;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    private EMove[] enemys;
    private float[] enemysDistance;
    public GameObject ex;
    public GameObject blood;

    

    private void Start()
    {
      
    }

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

        transform.position = new Vector3(posEnemy.x, posEnemy.y + 3, posEnemy.z);



    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag =="飛碟")
        {
            

            GameObject effect =  Instantiate(ex , transform.position , Quaternion.identity);
           
            GameObject Blood = Instantiate(blood, transform.position, blood.transform.rotation);
            Destroy(gameObject);
            Destroy(effect, 2f);
            Destroy(Blood, 5f);

            
        }



    }



    private void FixedUpdate()
    {
        Move();

    }

















}
