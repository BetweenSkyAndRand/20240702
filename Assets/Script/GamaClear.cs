using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GamaClear : MonoBehaviour
{
    Transform myTransform;
    // Start is called before the first frame update
    void Start()
    {
        //Transform�R���|�[�l���g��ۑ����Ă���
        myTransform = transform;
    }

    // Update is called once per frame
    void Update()
    {
        //�q���i�����������́j���Ȃ��Ȃ�����
        if(myTransform.childCount==0)
        {
            Time.timeScale = 0f;
        }
    }
}
