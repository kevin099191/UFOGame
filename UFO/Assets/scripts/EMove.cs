using UnityEngine;
using System.Collections;

public class EMove : MonoBehaviour
{
    public GameObject[] Elv = new GameObject[9];
    public float Elv_speed;
    public int s=3;



    private void Move()
    {
        //GameObject GB = Elv[Random.Range(0,9)];
        //GB.transform.localPosition = Vector3.MoveTowards(GB.transform.localPosition, new Vector3(GB.transform.localPosition.x, -0.5f, GB.transform.localPosition.z), Elv_speed*Time.deltaTime);

        Elv[8].transform.localPosition = Vector3.MoveTowards(Elv[8].transform.localPosition, new Vector3(Elv[8].transform.localPosition.x, -0.5f, Elv[8].transform.localPosition.z), Elv_speed * Time.deltaTime);



        //Elv[Random.Range(1,9)].transform.localPosition = Vector3.MoveTowards(gameObject.transform.localPosition, new Vector3(10, -3, 50), Elv_speed);


        












    }




    

    private IEnumerator RandomMove()
    {
        for (int i = 0; i < Elv.Length; i++)
        {
            Elv[i].transform.localPosition = Vector3.MoveTowards(Elv[i].transform.localPosition, new Vector3(Elv[i].transform.localPosition.x, -0.5f, Elv[i].transform.localPosition.z), Elv_speed * Time.deltaTime);

            yield return new WaitForSeconds(s);

            Elv[i].transform.localPosition = Vector3.MoveTowards(Elv[i].transform.localPosition, new Vector3(Elv[i].transform.localPosition.x, -25.0f, Elv[i].transform.localPosition.z), Elv_speed * Time.deltaTime);

            

        }

    }




    private void Update()
    {
        StartCoroutine(RandomMove());
    }















    private void Start()
    {
        Elv = GameObject.FindGameObjectsWithTag("電梯");

        
    }




}
