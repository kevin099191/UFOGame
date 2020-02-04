using UnityEngine;


public class EMove : MonoBehaviour
{
    
    public float speed=5;
    public int A;

    

    

    private void ReMove()
    {
        ///gameObject.transform.localPosition = Vector3.MoveTowards(gameObject.transform.localPosition, new Vector3(gameObject.transform.localPosition.x, -25f, gameObject.transform.localPosition.z), Elv_speed * Time.deltaTime);
    }


    

    private void Move()
    {

        /// gameObject.transform.localPosition = Vector3.MoveTowards(gameObject.transform.localPosition, new Vector3(gameObject.transform.localPosition.x, -0.5f, gameObject.transform.localPosition.z), Elv_speed * Time.deltaTime);

        A++;
        if (A<500)
        {
            gameObject.transform.position = new Vector3(gameObject.transform.position.x, gameObject.transform.position.y + speed * Time.deltaTime, gameObject.transform.position.z);
        }

        if (A > 500 && A < 800)
        {
            speed = 0;
        }

        if (A>800)
        {
            speed = 5;
            gameObject.transform.position = new Vector3(gameObject.transform.position.x, gameObject.transform.position.y  -  speed * Time.deltaTime, gameObject.transform.position.z);
        }
        
        if (A>1300)
        {
            A = 0;
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
