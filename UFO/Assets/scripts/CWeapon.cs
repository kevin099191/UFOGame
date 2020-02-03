
using UnityEngine;

public class CWeapon : MonoBehaviour
{
    public Transform[] point = new Transform[9];
    public GameObject ufo;









    private void Start()
    {
        //point = GameObject.FindGameObjectsWithTag("生成武器點");
       
    }


    private void Create()
    {


        if (Input.GetKeyDown(KeyCode.Keypad1))
        {
            
            //Instantiate(ufo, point[0].GetComponent<Transform>().position, Quaternion.identity);
            Instantiate(ufo, point[0].position, ufo.transform.rotation);
            
        }

        if (Input.GetKeyDown(KeyCode.Keypad2))
        {
            //Instantiate(ufo, point[1].GetComponent<Transform>().position, Quaternion.identity);
            Instantiate(ufo, point[1].position, ufo.transform.rotation);
        }

        if (Input.GetKeyDown(KeyCode.Keypad3))
        {
            //Instantiate(ufo, point[2].GetComponent<Transform>().position, Quaternion.identity);
            Instantiate(ufo, point[2].position, ufo.transform.rotation);
        }

    
        if (Input.GetKeyDown(KeyCode.Keypad4))
        {
            //Instantiate(ufo, point[3].GetComponent<Transform>().position, Quaternion.identity);
            Instantiate(ufo, point[3].position, ufo.transform.rotation);
        }

        if (Input.GetKeyDown(KeyCode.Keypad5))
        {
            //nstantiate(ufo, point[4].GetComponent<Transform>().position, Quaternion.identity);
            Instantiate(ufo, point[4].position, ufo.transform.rotation);
        }

        if (Input.GetKeyDown(KeyCode.Keypad6))
        {
            //Instantiate(ufo, point[5].GetComponent<Transform>().position, Quaternion.identity);
            Instantiate(ufo, point[5].position, ufo.transform.rotation);
        }

        if (Input.GetKeyDown(KeyCode.Keypad7))
        {
            // Instantiate(ufo, point[6].GetComponent<Transform>().position, Quaternion.identity);
            Instantiate(ufo, point[6].position, ufo.transform.rotation);
        }

        if (Input.GetKeyDown(KeyCode.Keypad8))
        {
            //  Instantiate(ufo, point[7].GetComponent<Transform>().position, Quaternion.identity);
            Instantiate(ufo, point[7].position, ufo.transform.rotation);
        }

        if (Input.GetKeyDown(KeyCode.Keypad9))
        {
            //  Instantiate(ufo, point[8].GetComponent<Transform>().position, Quaternion.identity);
            Instantiate(ufo, point[8].position, ufo.transform.rotation);
        }



        




    }

        





    private void Update()
    {
        Create();
    }






}
