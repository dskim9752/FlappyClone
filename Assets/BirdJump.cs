using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BirdJump : MonoBehaviour
{
    Rigidbody2D rb;
    public float jumpPower;
    public AudioClip[] jumpSfx;
    public AudioSource audioSource;
    int sfxIndex;
    int sfxLen;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        sfxLen = jumpSfx.Length;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))  // 마우스 왼쪽버튼
        {           
            rb.velocity = Vector2.up * jumpPower; //(0,3)
            sfxIndex = Random.Range(0, sfxLen); 
            audioSource.PlayOneShot(jumpSfx[sfxIndex]);
        }
    }

    private void OnCollisionEnter2D(Collision2D other) {
        if(Score.score > Score.bestScore)
        {
            Score.bestScore = Score.score;
        }
        SceneManager.LoadScene("GameOverScene");
    }
}
