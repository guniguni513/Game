using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting.ReorderableList;
using UnityEngine;

public class S2EnemyGenerator : MonoBehaviour
{
    public Transform player;
    public GameObject Enemy1;
    public GameObject Enemy3;
    public GameObject Enemy4;
    public float span=2.0f;
    float delta=0;
    public float dist=20f;//生成されるプレイヤーからの距離
    public float EnemySum=100f;//出現する敵の数

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        this.delta+=Time.deltaTime;
        if(this.delta>this.span){
            this.delta=0;
            GameObject item;
            int dice=Random.Range(1,11);//1~10
            if(dice<=4){//ratio以下の時
                item=Instantiate(Enemy1);
            }else if(dice<=8){
                item=Instantiate(Enemy4);
            }else{
                item=Instantiate(Enemy3);
            }
            //Prefabのy座標取得
            float prefabY=item.transform.position.y;

            //プレイヤーからdist離れたとこにランダムで生成
            float x=Random.Range(player.position.x-dist,player.position.x+dist);
            float z=Random.Range(player.position.z-dist,player.position.z+dist);
            item.transform.position=new Vector3(x,prefabY,z);
            EnemySum--;
            if(EnemySum==0){
                enabled=false;//Updateを停止する
            }
        }   
    }
}


