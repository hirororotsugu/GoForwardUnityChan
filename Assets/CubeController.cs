using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeController : MonoBehaviour
{
    //�L���[�u�̈ړ����x
    private float speed = -12;

    //���ňʒu
    private float deadLine = -10;

    //�I�[�f�B�I�̕ϐ�
    public AudioClip sound1;
    private AudioSource audioSource;


    // Start is called before the first frame update
    void Start()
    {
        //�I�[�f�B�I�R���|�[�l���g�擾
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        //�L���[�u���ړ�������
        transform.Translate(this.speed * Time.deltaTime, 0, 0);

        //��ʊO�ɏo����j������
        if(transform.position.x < this.deadLine)
        {
            Destroy(gameObject);
        }
    }

    //�L���[�u��Unity�����ȊO�̃R���C�_�[�ɏՓ˂����Ƃ�
    void OnCollisionEnter2D(Collision2D colli)
    {
        if (colli.gameObject.tag != "unitychan")
        {
            audioSource.PlayOneShot(sound1);
            Debug.Log("�r�d�Đ�");
        }
    }
}
