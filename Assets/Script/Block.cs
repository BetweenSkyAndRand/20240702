using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Block : MonoBehaviour
{

    //スコア
    public int score = 10;
    private BlockGenelator blockGenerator;
    //何かとぶつかったときに呼ばれる
    private void Start()
    {
        blockGenerator = FindObjectOfType<BlockGenelator>();
    }
    private void OnCollisionEnter(Collision collision)
    {
        if(ScoreScript.instance!=null)
        {
            ScoreScript.instance.ScoreManager(score);
        }
        else
        {
            Debug.LogError("ScoreScriptのインスタンスがありません。");
        }
        //ブロックがぶつかった時に生成したカウントを減らしていく
        blockGenerator.BlockDestoroyed();
        //ゲームオブジェクトを削除する
        Destroy(gameObject);
    }
}
