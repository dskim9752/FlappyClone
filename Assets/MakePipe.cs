using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MakePipe : MonoBehaviour
{
    public GameObject pipe;    // prefab 받아오기
    public float timeDiff = 1;
    float timer = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //파이프 찍어내기, 동일한 시간 간격으로
        timer += Time.deltaTime;
        if(timer > timeDiff)
        {
            GameObject newPipe = Instantiate(pipe);
            newPipe.transform.position = new Vector3(3,Random.Range(-6.0f,1.0f),0);   // x = 3 ,   y = -6~1 랜덤
            timer = 0;
            Destroy(newPipe, 5.0f);
        }

    }
}
