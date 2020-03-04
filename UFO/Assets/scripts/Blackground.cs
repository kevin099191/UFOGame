
using UnityEngine;

public class Blackground : MonoBehaviour
{

    public float speed=0.13f;
    public Material bg_material;
    public AudioClip AC;
    public AudioSource AS;
    public GameObject SG;
    private void Start()
    {
        bg_material = GetComponent<Renderer>().material;
        AS.PlayOneShot(AC, 0.5f);
    }
    private void Update()
    {
        float offset = Time.time * speed;

        bg_material.SetTextureOffset("_MainTex", new Vector2(0, -offset));
       
    }

   
}
