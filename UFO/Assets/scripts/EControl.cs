using System.Collections;

using UnityEngine;

public class EControl : EMove
{
    public GameObject[] Elv = new GameObject[9];







    private IEnumerator Ct()
    {
        for (int j = 0; j < 500; j++)
        {
            int i = Random.Range(1, 10);

            GameObject.Find("電梯[i]").GetComponent<EMove>().enabled = true;


            

            if (A>13)
            {
                GameObject.Find("電梯[i]").GetComponent<EMove>().enabled = false;
            }

            yield return new WaitForSeconds(3);

        }
       

        

    }




    private void Start()
    {
        Elv = GameObject.FindGameObjectsWithTag("電梯");
        StartCoroutine(Ct());
    }










}
