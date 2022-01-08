using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePipe : MonoBehaviour
{
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       // Debug.Log(transform.position);  //z까지 포함됨
       transform.position += Vector3.left * Time.deltaTime * speed; //(-1,0,0) * 보정
       //(업데이트 함수에서 기기마다의 fps 차이 맞춰줘야함 =  deltaTime 곱하기)
    }
}
