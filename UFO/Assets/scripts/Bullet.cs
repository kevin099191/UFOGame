
using UnityEngine;

public class Bullet : MonoBehaviour
{

    private CWeapon cw;
    public GameObject SM;




    private void Start()
    {
        SM = GameObject.Find("分數管理器");
    }



    private  void OnCollisionEnter(Collision other) 
    { 
       if (other.gameObject.tag =="男孩")
        {
            SM.GetComponent<ScoreManager>(). AddScore(100);
        } 
        
        if (other.gameObject.tag =="女孩")
        {
            SM.GetComponent<ScoreManager>().AddScore(-1000);
        }
        Destroy(gameObject);
    }




    private void Update()
    {
       
    }











   
}
