using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController : MonoBehaviour
{
    public GameObject player;
    public GameObject HitEffect;
    Ray ray;
    
    RaycastHit hit;
    // Start is called before the first frame update
    void Start()
    {
    //画面の中心に向かってraycastを飛ばす
       ray = Camera.main.ScreenPointToRay(
        Camera.main.ViewportToScreenPoint(Camera.main.rect.center)
        );
        
        Vector3 ofset = new Vector3(0,0.05f,0);
        if(Physics.Raycast(ray,out hit, 100f)) {
            ofset = new Vector3(0,1.0f/hit.distance,0);
        }

        GetComponent<Rigidbody>().velocity=(ray.direction+ofset)* 40.0f;
        
        Debug.Log(hit.distance);
        Destroy(gameObject,1.0f);
    }
    private void OnCollisionEnter(Collision other) {
        Instantiate(HitEffect, hit.point, Quaternion.identity);
        if(other.gameObject.CompareTag("Enemy")){
            Destroy(other.gameObject);
        }
        Destroy(gameObject);
        Destroy(HitEffect,0.5f);
    }
    void Update(){
        
    }       


}