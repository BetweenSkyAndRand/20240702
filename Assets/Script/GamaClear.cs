using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GamaClear : MonoBehaviour
{
    Transform myTransform;
    // Start is called before the first frame update
    void Start()
    {
        //Transformコンポーネントを保存しておく
        myTransform = transform;
    }

    // Update is called once per frame
    void Update()
    {
        //子供（生成したもの）がなくなったら
        if(myTransform.childCount==0)
        {
            Time.timeScale = 0f;
        }
    }
}
