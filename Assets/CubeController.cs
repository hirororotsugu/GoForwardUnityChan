using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeController : MonoBehaviour
{
    //キューブの移動速度
    private float speed = -12;

    //消滅位置
    private float deadLine = -10;

    //オーディオの変数
    public AudioClip sound1;
    private AudioSource audioSource;


    // Start is called before the first frame update
    void Start()
    {
        //オーディオコンポーネント取得
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        //キューブを移動させる
        transform.Translate(this.speed * Time.deltaTime, 0, 0);

        //画面外に出たら破棄する
        if(transform.position.x < this.deadLine)
        {
            Destroy(gameObject);
        }
    }

    //キューブがUnityちゃん以外のコライダーに衝突したとき
    void OnCollisionEnter2D(Collision2D colli)
    {
        if (colli.gameObject.tag != "unitychan")
        {
            audioSource.PlayOneShot(sound1);
            Debug.Log("ＳＥ再生");
        }
    }
}
