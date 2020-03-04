using UnityEngine;


public class EMove : MonoBehaviour
{
    
    public float speed=5;
    public float A;

    

    

   


    

    private void Move()
    {

        

        A += Time.deltaTime; 
        if (A<5)
        {
            gameObject.transform.position = new Vector3(gameObject.transform.position.x, gameObject.transform.position.y + speed * Time.deltaTime, gameObject.transform.position.z);
        }

        if (A > 5&& A < 8)
        {
            speed = 0;
        }

        if (A>8)
        {
            speed = 5;
            gameObject.transform.position = new Vector3(gameObject.transform.position.x, gameObject.transform.position.y  -  speed * Time.deltaTime, gameObject.transform.position.z);
        }
        
        if (A>13)
        {
            Destroy(this);
        }


        




    }
    

    private void Update()
    {
        Move();
      
    }















    private void Start()
    {
        

        
    }




}
