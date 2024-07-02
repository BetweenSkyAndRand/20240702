using System.Collections;
using System.Collections.Generic;
using System.Xml.Schema;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.SocialPlatforms.Impl;

public class BlockGenelator : MonoBehaviour
{
    //GameObject
    public GameObject blockPrefab;//ブロックのプレファブ
    //ブロックの座標・大きさ
    float span = 0.3f;//ブロックの間隔
    int row = 4;//ブロックの列
    int col = 7;//ブロックの行
    int blockScaleX = 2;//ブロックの幅
    int blockScaleY = 1;//ブロックの高さ
    int totalblocks;
    // Start is called before the first frame update
    void Start()
    {
        int px=-7, py=5;//ブロックの座標
        int scoreDefult = 0;//スコアのデフォルト設定
        //ブロックの総数を計算
        totalblocks = row * col;
        //ブロックの表示
        for(int i = 0; i < row; i++) 
        {
            for(int j = 0; j < col; j++)
            {
                //ゲームオブジェクトとして生成
                GameObject go = Instantiate(blockPrefab);
                go.transform.position= new Vector3(px+(j*(span+blockScaleX)),py+(i*(span+blockScaleY)),0);
            }
        }
        //スコアの初期表示
        if (ScoreScript.instance != null)
        {
            ScoreScript.instance.ScoreManager(scoreDefult);
        }
        else
        {
            Debug.LogError("ScoreScriptのインスタンスがありません。");
        }

    }
    //ブロックがすべて破壊されたかどうかのメソッド
    public void BlockDestoroyed()
    {
        totalblocks--;
        if(totalblocks<=0)
        {
            SceneManager.LoadScene("Result");
        }
    }

}
