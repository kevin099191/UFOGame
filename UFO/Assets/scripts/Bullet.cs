
using UnityEngine;

public class Bullet : MonoBehaviour
{

    private CWeapon cw;
    public GameObject SM;




    private void Start()
    {
        SM = GameObject.Find("分數管理器");
        cw = FindObjectOfType<CWeapon>();
        Physics.IgnoreLayerCollision(11, 11);
    }



    private  void OnCollisionEnter(Collision other) 
    { 
       if (other.gameObject.tag =="男孩")
        {
            SM.GetComponent<ScoreManager>(). AddScore(100);
            cw.bulletNum++;
        } 
        
        if (other.gameObject.tag =="女孩")
        {
            SM.GetComponent<ScoreManager>().AddScore(-1000);
            cw.bulletNum --;
        }
        Destroy(gameObject);
    }




    private void Update()
    {
       
    }











   
}
