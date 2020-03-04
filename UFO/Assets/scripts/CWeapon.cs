
using UnityEngine;

public class CWeapon : MonoBehaviour
{
    public Transform[] point = new Transform[9];
    public GameObject ufo;
    public GameObject weapon;

    public int bulletNum = 6;

    public GameObject[] bullet;
    public GameObject Ed;



    private void Start()
    {
       /// bullet = GameObject.FindGameObjectsWithTag("飛彈圖");
        bulletNum = 6;
    }


    public void BulletNum()
    {
        if (bulletNum == 6)
        {
            bullet[0].SetActive(true);
            bullet[1].SetActive(true);
            bullet[2].SetActive(true);
            bullet[3].SetActive(true);
            bullet[4].SetActive(true);
            bullet[5].SetActive(true);
        }
        else if (bulletNum == 5)
        {
            bullet[0].SetActive(true);
            bullet[1].SetActive(true);
            bullet[2].SetActive(true);
            bullet[3].SetActive(true);
            bullet[4].SetActive(true);
            bullet[5].SetActive(false);
        }
        else if (bulletNum == 4)
        {
            bullet[0].SetActive(true);
            bullet[1].SetActive(true);
            bullet[2].SetActive(true);
            bullet[3].SetActive(true);
            bullet[4].SetActive(false);
            bullet[5].SetActive(false);
        }
        else if (bulletNum == 3)
        {
            bullet[0].SetActive(true);
            bullet[1].SetActive(true);
            bullet[2].SetActive(true);
            bullet[3].SetActive(false);
            bullet[4].SetActive(false);
            bullet[5].SetActive(false);
        }
        else if (bulletNum == 2)
        {
            bullet[0].SetActive(true);
            bullet[1].SetActive(true);
            bullet[2].SetActive(false);
            bullet[3].SetActive(false);
            bullet[4].SetActive(false);
            bullet[5].SetActive(false);
        }
        else if (bulletNum == 1)
        {
            bullet[0].SetActive(true);
            bullet[1].SetActive(false);
            bullet[2].SetActive(false);
            bullet[3].SetActive(false);
            bullet[4].SetActive(false);
            bullet[5].SetActive(false);
        }
        else if (bulletNum == 0)
        {
            bullet[0].SetActive(false);
            bullet[1].SetActive(false);
            bullet[2].SetActive(false);
            bullet[3].SetActive(false);
            bullet[4].SetActive(false);
            bullet[5].SetActive(false);


            Ed.SetActive(true);











        }


    }


    public void BD()
    {
        bulletNum++;
    }





    private void Create()
    {


        if (Input.GetKeyDown(KeyCode.Keypad1))
        {

            Instantiate(ufo, point[0].position, ufo.transform.rotation);
            Instantiate(weapon, point[0].position + transform.up * -3, weapon.transform.rotation);
            bulletNum--;

        }
           if (Input.GetKeyDown(KeyCode.Keypad2))
            {

                Instantiate(ufo, point[1].position, ufo.transform.rotation);
                Instantiate(weapon, point[1].position + transform.up * -3, weapon.transform.rotation);
            bulletNum--;
        }

            if (Input.GetKeyDown(KeyCode.Keypad3))
            {

                Instantiate(ufo, point[2].position, ufo.transform.rotation);
                Instantiate(weapon, point[2].position + transform.up * -3, weapon.transform.rotation);
            bulletNum--;
        }


            if (Input.GetKeyDown(KeyCode.Keypad4))
            {

                Instantiate(ufo, point[3].position, ufo.transform.rotation);
                Instantiate(weapon, point[3].position + transform.up * -3, weapon.transform.rotation);
            bulletNum--;
        }

            if (Input.GetKeyDown(KeyCode.Keypad5))
            {

                Instantiate(ufo, point[4].position, ufo.transform.rotation);
                Instantiate(weapon, point[4].position + transform.up * -3, weapon.transform.rotation);
            bulletNum--;
        }

            if (Input.GetKeyDown(KeyCode.Keypad6))
            {

                Instantiate(ufo, point[5].position, ufo.transform.rotation);
                Instantiate(weapon, point[5].position + transform.up * -3, weapon.transform.rotation);
            bulletNum--;
        }

            if (Input.GetKeyDown(KeyCode.Keypad7))
            {

                Instantiate(ufo, point[6].position, ufo.transform.rotation);
                Instantiate(weapon, point[6].position + transform.up * -3, weapon.transform.rotation);
            bulletNum--;
        }

            if (Input.GetKeyDown(KeyCode.Keypad8))
            {

                Instantiate(ufo, point[7].position, ufo.transform.rotation);
                Instantiate(weapon, point[7].position + transform.up * -3, weapon.transform.rotation);
            bulletNum--;
        }

            if (Input.GetKeyDown(KeyCode.Keypad9))
            {

                Instantiate(ufo, point[8].position, ufo.transform.rotation);
                Instantiate(weapon, point[8].position + transform.up * -3, weapon.transform.rotation);
            bulletNum--;
        }



          




        }



    



     private void Update()
    {
        Create();
        BulletNum();
    }






}
