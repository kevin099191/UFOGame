using System.Collections;

using UnityEngine;

public class EControl : MonoBehaviour
{
    public GameObject[] Elv = new GameObject[9];
    public GameObject[] point = new GameObject[9];
    public GameObject[] player = new GameObject[2];
   
    private Screan Sc;



    private IEnumerator Ct()
    {
        for (int j = 0; j < 500; j++)
        {
            
            
              
            
            

            
            int i = Random.Range(0, 9);

            
            Elv[i].AddComponent<EMove>();
            Vector3 p = point[i].transform.position;
            int rp = Random.Range(0 ,2);
            GameObject S = Instantiate(player[rp], p  , new Quaternion(0, 180, 0, 0));
            Destroy(S, 13);

            yield return new WaitForSeconds(6);

        }
       

        

    }




    private void Start()
    {
        Elv = GameObject.FindGameObjectsWithTag("電梯");
        point = GameObject.FindGameObjectsWithTag("敵人點");
        StartCoroutine(Ct());
        Sc = FindObjectOfType<Screan>();

    }












}
