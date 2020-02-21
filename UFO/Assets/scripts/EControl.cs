using System.Collections;

using UnityEngine;

public class EControl : MonoBehaviour
{
    public GameObject[] Elv = new GameObject[9];
    public GameObject[] point = new GameObject[9];

    public GameObject emenyBoy;




    private IEnumerator Ct()
    {
        for (int j = 0; j < 500; j++)
        {
            
            int i = Random.Range(0, 9);

            
            Elv[i].AddComponent<EMove>();
            Vector3 p = point[i].transform.position;
            Instantiate(emenyBoy , p , Quaternion.identity);
            

            yield return new WaitForSeconds(3);

        }
       

        

    }




    private void Start()
    {
        Elv = GameObject.FindGameObjectsWithTag("電梯");
        point = GameObject.FindGameObjectsWithTag("敵人點");
        StartCoroutine(Ct());
    }










}
