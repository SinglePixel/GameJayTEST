using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuffSpwaner : MonoBehaviour
{
    public List<GameObject> platforms2 = new List<GameObject>();

    private float spwanTime2;//����ʱ��
    private float countTime2;//���ɼ���
    private Vector3 spwanPosition2;//������Χ
    void Start()
    {
        
    }
    void Update()
    {
        
        SpwanPlatform();

    }

    public void SpwanPlatform()
    {
        spwanTime2 = Random.Range(7, 15);
        countTime2 += Time.deltaTime;
        spwanPosition2 = transform.position;
        spwanPosition2.x = Random.Range(-6, 6);
        if (countTime2 >= spwanTime2)
        {
            CreatePlatform();
            countTime2 = 0;
        }
    }

    //ƽ̨���ɷ���
    public void CreatePlatform()
    {
        int index = Random.Range(0, platforms2.Count);

        Instantiate(platforms2[index], spwanPosition2, Quaternion.identity);
    }
    
}
