using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    //��(WallBottom)�ɂԂ������Ƃ�
    private void OnCollisionEnter(Collision collision)
    {
        Destroy(collision.gameObject);
        SceneManager.LoadScene("Result");
    }

}
