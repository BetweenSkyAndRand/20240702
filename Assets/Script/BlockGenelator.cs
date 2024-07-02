using System.Collections;
using System.Collections.Generic;
using System.Xml.Schema;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.SocialPlatforms.Impl;

public class BlockGenelator : MonoBehaviour
{
    //GameObject
    public GameObject blockPrefab;//�u���b�N�̃v���t�@�u
    //�u���b�N�̍��W�E�傫��
    float span = 0.3f;//�u���b�N�̊Ԋu
    int row = 4;//�u���b�N�̗�
    int col = 7;//�u���b�N�̍s
    int blockScaleX = 2;//�u���b�N�̕�
    int blockScaleY = 1;//�u���b�N�̍���
    int totalblocks;
    // Start is called before the first frame update
    void Start()
    {
        int px=-7, py=5;//�u���b�N�̍��W
        int scoreDefult = 0;//�X�R�A�̃f�t�H���g�ݒ�
        //�u���b�N�̑������v�Z
        totalblocks = row * col;
        //�u���b�N�̕\��
        for(int i = 0; i < row; i++) 
        {
            for(int j = 0; j < col; j++)
            {
                //�Q�[���I�u�W�F�N�g�Ƃ��Đ���
                GameObject go = Instantiate(blockPrefab);
                go.transform.position= new Vector3(px+(j*(span+blockScaleX)),py+(i*(span+blockScaleY)),0);
            }
        }
        //�X�R�A�̏����\��
        if (ScoreScript.instance != null)
        {
            ScoreScript.instance.ScoreManager(scoreDefult);
        }
        else
        {
            Debug.LogError("ScoreScript�̃C���X�^���X������܂���B");
        }

    }
    //�u���b�N�����ׂĔj�󂳂ꂽ���ǂ����̃��\�b�h
    public void BlockDestoroyed()
    {
        totalblocks--;
        if(totalblocks<=0)
        {
            SceneManager.LoadScene("Result");
        }
    }

}
